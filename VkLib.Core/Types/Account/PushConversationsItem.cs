using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class PushConversationsItem
    {
        /// <summary>
        /// Peer ID
        /// </summary>
        [JsonProperty("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Information whether the sound are enabled
        /// </summary>
        [JsonProperty("sound")]
        public BoolInt Sound { get; set; }

        /// <summary>
        /// Time until that notifications are disabled in seconds
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }

    }
}
