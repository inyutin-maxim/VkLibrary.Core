using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Friends
{
    /// <summary>
    /// API RequestsMutual object.
    /// </summary>
    public class RequestsMutual
    {
        /// <summary>
        /// Total mutual friends number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public IEnumerable<int?> Users { get; set; }
    }
}