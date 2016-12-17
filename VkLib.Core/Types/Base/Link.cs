using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class Link
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("product")]
        public LinkProduct Product { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("application")]
        public LinkApplication Application { get; set; }

        /// <summary>
        /// Link title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// URL of the page with article preview
        /// </summary>
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// String ID of the page with article preview
        /// </summary>
        [JsonProperty("preview_page")]
        public string PreviewPage { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rating")]
        public LinkRating Rating { get; set; }

        /// <summary>
        /// Link description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Link caption
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("button")]
        public LinkButton Button { get; set; }

        /// <summary>
        /// Information whether the link is external
        /// </summary>
        [JsonProperty("is_external")]
        public BoolInt IsExternal { get; set; }

    }
}
