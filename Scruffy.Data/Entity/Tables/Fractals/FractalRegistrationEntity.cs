﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scruffy.Data.Entity.Tables.Fractals
{
    /// <summary>
    /// Registration of an fractal appointment
    /// </summary>
    [Table("FractalRegistrations")]
    public class FractalRegistrationEntity
    {
        #region Properties

        /// <summary>
        /// Id of the configuration
        /// </summary>
        public long ConfigurationId { get; set; }

        /// <summary>
        /// Timestamp of the appointment
        /// </summary>
        public DateTime AppointmentTimeStamp { get; set; }

        /// <summary>
        /// Id of the user
        /// </summary>
        public ulong UserId { get; set; }

        /// <summary>
        /// Timestamp of the registration
        /// </summary>
        public DateTime RegistrationTimeStamp { get; set; }

        #region Navigation properties

        /// <summary>
        /// Configuration
        /// </summary>
        public virtual FractalLfgConfigurationEntity FractalLfgConfiguration { get; set; }

        #endregion // Navigation properties

        #endregion // Properties
    }
}