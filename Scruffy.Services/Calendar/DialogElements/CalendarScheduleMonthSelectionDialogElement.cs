﻿using Scruffy.Services.Core.Localization;
using Scruffy.Services.Discord;

namespace Scruffy.Services.Calendar.DialogElements;

/// <summary>
/// Month selection
/// </summary>
public class CalendarScheduleMonthSelectionDialogElement : DialogMultiSelectSelectMenuElementBase<int>
{
    #region Constructor

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="localizationService">Localization service</param>
    public CalendarScheduleMonthSelectionDialogElement(LocalizationService localizationService)
        : base(localizationService)
    {
    }

    #endregion // Constructor

    #region DialogEmbedMultiSelectSelectMenuElementBase<int>

    /// <summary>
    /// Max values
    /// </summary>
    protected override int MaxValues => 12;

    /// <summary>
    /// Return the message of element
    /// </summary>
    /// <returns>Message</returns>
    public override Task<string> GetMessage() => Task.FromResult(LocalizationGroup.GetText("Message", "Please select the months:"));

    /// <summary>
    /// Returns the select menu entries which should be added to the message
    /// </summary>
    /// <returns>Reactions</returns>
    public override IReadOnlyList<SelectMenuOptionData> GetEntries()
    {
        var entries = new List<SelectMenuOptionData>();

        for (var i = 1; i <= 12; i++)
        {
            entries.Add(new SelectMenuOptionData
                        {
                            Value = i.ToString(),
                            Label = new DateTime(1, i, 1).ToString("MMMM", LocalizationGroup.CultureInfo)
                        });
        }

        return entries;
    }

    #endregion // DialogEmbedMultiSelectSelectMenuElementBase<int>
}