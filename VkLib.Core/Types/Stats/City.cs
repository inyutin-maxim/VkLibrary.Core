using System;
using Newtonsoft.Json;

namespace VkLib.Types.Stats 
{
    public class City
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value { get; set; }

    }
}
