using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class PostSource
    {
        /// <summary>
        /// Type of post source
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Additional data
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// URL to an external site used to publish the post
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Platform name
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

    }
}
