using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class Info
    {
        /// <summary>
        /// Information whether only owners posts should be shown
        /// </summary>
        [JsonProperty("own_posts_default")]
        public BoolInt OwnPostsDefault { get; set; }

        /// <summary>
        /// Information whether user has been processed intro 
        /// </summary>
        [JsonProperty("intro")]
        public BoolInt Intro { get; set; }

        /// <summary>
        /// Information whether wall comments should be hidden
        /// </summary>
        [JsonProperty("no_wall_replies")]
        public BoolInt NoWallReplies { get; set; }

        /// <summary>
        /// Information whether HTTPS-only is enabled
        /// </summary>
        [JsonProperty("https_required")]
        public BoolInt HttpsRequired { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Language ID
        /// </summary>
        [JsonProperty("lang")]
        public int? Lang { get; set; }

        /// <summary>
        /// Two factor authentication is enabled
        /// </summary>
        [JsonProperty("2fa_required")]
        public BoolInt 2faRequired { get; set; }

    }
}
