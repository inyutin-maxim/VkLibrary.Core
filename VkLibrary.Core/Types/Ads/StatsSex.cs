using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API StatsSex object.
    /// </summary>
    public class StatsSex
    {
        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Impressions rate
        /// </summary>
        [JsonProperty("impressions_rate")]
        public uint? ImpressionsRate { get; set; }

        /// <summary>
        /// Clicks rate
        /// </summary>
        [JsonProperty("clicks_rate")]
        public uint? ClicksRate { get; set; }
    }
}