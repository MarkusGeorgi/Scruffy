﻿using System.Reflection;

using Discord;

using Microsoft.EntityFrameworkCore;

using Scruffy.Data.Entity;
using Scruffy.Data.Entity.Repositories.CoreData;
using Scruffy.Services.Core.Localization;
using Scruffy.Services.Discord;

namespace Scruffy.Services.Configuration.DialogElements;

/// <summary>
/// Server configuration
/// </summary>
public class ServerConfigurationDialogElement : DialogEmbedSelectMenuElementBase<bool>
{
    #region Fields

    /// <summary>
    /// Repository factory
    /// </summary>
    private readonly RepositoryFactory _repositoryFactory;

    #endregion // Fields

    #region Constructor

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="localizationService">Localization service</param>
    /// <param name="repositoryFactory">Repository factory</param>
    public ServerConfigurationDialogElement(LocalizationService localizationService,
                                            RepositoryFactory repositoryFactory)
        : base(localizationService)
    {
        _repositoryFactory = repositoryFactory;
    }

    #endregion // Constructor

    #region DialogSelectMenuElementBase

    /// <summary>
    /// Return the message of element
    /// </summary>
    /// <returns>Message</returns>
    public override Task<EmbedBuilder> GetMessage()
    {
        var builder = new EmbedBuilder().WithTitle(LocalizationGroup.GetText("Title", "Server configuration"))
                                        .WithDescription(LocalizationGroup.GetText("Description", "With the following assistant you are able to configure your server."))
                                        .WithFooter("Scruffy", "https://cdn.discordapp.com/app-icons/838381119585648650/823930922cbe1e5a9fa8552ed4b2a392.png?size=64")
                                        .WithColor(Color.Green)
                                        .WithTimestamp(DateTime.Now);

        return Task.FromResult(builder);
    }

    /// <summary>
    /// Returning the placeholder
    /// </summary>
    /// <returns>Placeholder</returns>
    public override string GetPlaceholder() => LocalizationGroup.GetText("ChooseAction", "Choose one of the following options...");

    /// <summary>
    /// Returns the select menu entries which should be added to the message
    /// </summary>
    /// <returns>Reactions</returns>
    public override IReadOnlyList<SelectMenuEntryData<bool>> GetEntries()
    {
        return new List<SelectMenuEntryData<bool>>
               {
                   new()
                   {
                       CommandText = LocalizationGroup.GetText("InstallSlashCommands", "Slash command installation"),
                       Response = async () =>
                              {
                                  IEnumerable<ApplicationCommandProperties> commands = null;

                                  var buildContext = new SlashCommandBuildContext
                                                     {
                                                         Guild = CommandContext.Guild,
                                                         ServiceProvider = CommandContext.ServiceProvider,
                                                         CultureInfo = LocalizationGroup.CultureInfo
                                                     };

                                  foreach (var type in Assembly.Load("Scruffy.Commands")
                                                               .GetTypes()
                                                               .Where(obj => typeof(SlashCommandModuleBase).IsAssignableFrom(obj)
                                                                          && obj.IsAbstract == false))
                                  {
                                      var commandModule = (SlashCommandModuleBase)Activator.CreateInstance(type);
                                      if (commandModule != null)
                                      {
                                          commands = commands == null
                                                         ? commandModule.GetCommands(buildContext)
                                                         : commands.Concat(commandModule.GetCommands(buildContext));
                                      }
                                  }

                                  if (commands != null)
                                  {
                                      try
                                      {
                                          await CommandContext.Guild
                                                              .BulkOverwriteApplicationCommandsAsync(commands.ToArray())
                                                              .ConfigureAwait(false);
                                      }
                                      catch
                                      {
                                          // TODO Currently throwing an exception after the creation of the commands
                                      }
                                  }

                                  return true;
                              }
                   },
                   new()
                   {
                       CommandText = LocalizationGroup.GetText("UninstallSlashCommands", "Slash command uninstallation"),
                       Response = async () =>
                              {
                                  await CommandContext.Guild
                                                      .BulkOverwriteApplicationCommandsAsync(Array.Empty<ApplicationCommandProperties>())
                                                      .ConfigureAwait(false);

                                  return true;
                              }
                   }
               };
    }

    /// <summary>
    /// Default case if none of the given buttons is used
    /// </summary>
    /// <returns>Result</returns>
    protected override bool DefaultFunc() => false;

    #endregion // DialogSelectMenuElementBase<bool>
}