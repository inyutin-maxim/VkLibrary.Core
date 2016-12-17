using System;
using Newtonsoft.Json;

namespace VkLib.Types.Market 
{
    public class MarketCategory
    {
        /// <summary>
        /// Category ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("section")]
        public Section Section { get; set; }

    }
}
