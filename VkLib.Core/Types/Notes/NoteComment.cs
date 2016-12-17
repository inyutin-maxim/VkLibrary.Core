using System;
using Newtonsoft.Json;

namespace VkLib.Types.Notes 
{
    public class NoteComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Note ID
        /// </summary>
        [JsonProperty("oid")]
        public int? Oid { get; set; }

        /// <summary>
        /// ID of replied comment 
        /// </summary>
        [JsonProperty("reply_to")]
        public int? ReplyTo { get; set; }

        /// <summary>
        /// Note ID
        /// </summary>
        [JsonProperty("nid")]
        public int? Nid { get; set; }

        /// <summary>
        /// Date when the comment has beed added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment author's ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
