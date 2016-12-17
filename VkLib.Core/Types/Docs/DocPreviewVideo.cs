using System;
using Newtonsoft.Json;

namespace VkLib.Types.Docs 
{
    public class DocPreviewVideo
    {
        /// <summary>
        /// Video URL
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Video's height in pixels
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Video's width in pixels
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Video file size in bites
        /// </summary>
        [JsonProperty("filesize")]
        public int? Filesize { get; set; }

    }
}
