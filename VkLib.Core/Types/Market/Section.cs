using System;
using Newtonsoft.Json;

namespace VkLib.Types.Market 
{
    public class Section
    {
        /// <summary>
        /// Section ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Section name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
