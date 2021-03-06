using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Apps
{
    /// <summary>
    /// API Leaderboard object.
    /// </summary>
    public class Leaderboard
    {
        /// <summary>
        /// Score number
        /// </summary>
        [JsonProperty("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [JsonProperty("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Points number
        /// </summary>
        [JsonProperty("points")]
        public int? Points { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }
    }
}