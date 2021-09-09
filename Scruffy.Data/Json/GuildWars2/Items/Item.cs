﻿using Newtonsoft.Json;

namespace Scruffy.Data.Json.GuildWars2.Items
{
    /// <summary>
    /// Item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Vendor value
        /// </summary>
        [JsonProperty("vendor_value")]
        public long? VendorValue { get; set; }
    }
}
