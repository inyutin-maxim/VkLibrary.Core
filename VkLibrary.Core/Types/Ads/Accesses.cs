using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class Accesses
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }
}