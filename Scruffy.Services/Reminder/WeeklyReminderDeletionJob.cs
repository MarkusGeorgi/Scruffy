﻿using System.Linq;
using System.Threading.Tasks;

using DSharpPlus;

using Microsoft.Extensions.DependencyInjection;

using Scruffy.Data.Entity;
using Scruffy.Data.Entity.Repositories.Reminder;
using Scruffy.Services.Core;
using Scruffy.Services.Core.JobScheduler;

namespace Scruffy.Services.Reminder
{
    /// <summary>
    /// Deletion of a weekly reminder
    /// </summary>
    public class WeeklyReminderDeletionJob : AsyncJob
    {
        #region Fields

        /// <summary>
        /// Id of the reminder
        /// </summary>
        private long _id;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        public WeeklyReminderDeletionJob(long id)
        {
            _id = id;
        }

        #endregion // Constructor

        #region  AsyncJob

        /// <summary>
        /// Executes the job
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        protected override async Task ExecuteAsync()
        {
            await using (var serviceProvider = GlobalServiceProvider.Current.GetServiceProvider())
            {
                using (var dbFactory = RepositoryFactory.CreateInstance())
                {
                    var data = dbFactory.GetRepository<WeeklyReminderRepository>()
                                        .GetQuery()
                                        .Where(obj => obj.Id == _id)
                                        .Select(obj => new
                                                       {
                                                           obj.ChannelId,
                                                           obj.MessageId
                                                       })
                                        .FirstOrDefault();

                    if (data?.MessageId != null)
                    {
                        var discordClient = serviceProvider.GetService<DiscordClient>();

                        var channel = await discordClient.GetChannelAsync(data.ChannelId);

                        var message = await channel.GetMessageAsync(data.MessageId.Value);

                        await channel.DeleteMessageAsync(message);

                        dbFactory.GetRepository<WeeklyReminderRepository>()
                                 .Refresh(obj => obj.Id == _id,
                                          obj => obj.MessageId = null);
                    }
                }
            }
        }

        #endregion // AsyncJob
    }
}