using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemFriend
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friends")]
        public object Friends { get; set; }

    }
}
