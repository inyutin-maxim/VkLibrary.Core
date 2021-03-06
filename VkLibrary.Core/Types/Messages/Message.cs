using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API Message object.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// URL of the preview image with 200px in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// URL of the preview image with 50px in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// ID used for sending messages. It returned only for outgoing messages
        /// </summary>
        [JsonProperty("random_id")]
        public int? RandomId { get; set; }

        /// <summary>
        /// Is it an deleted message
        /// </summary>
        [JsonProperty("deleted")]
        public int? Deleted { get; set; }

        /// <summary>
        /// Chat ID
        /// </summary>
        [JsonProperty("chat_id")]
        public int? ChatId { get; set; }

        /// <summary>
        /// Information whether the messages is read
        /// </summary>
        [JsonProperty("read_state")]
        public int? ReadState { get; set; }

        /// <summary>
        /// Message author's ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Message title or chat title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the preview image with 100px in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// Message author's ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Chat administrator ID
        /// </summary>
        [JsonProperty("admin_id")]
        public int? AdminId { get; set; }

        /// <summary>
        /// Date when the message has been sent in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public double? Date { get; set; }

        /// <summary>
        /// Forwarded messages
        /// </summary>
        [JsonProperty("fwd_messages")]
        public IEnumerable<Message> FwdMessages { get; set; }

        /// <summary>
        /// Chat users number
        /// </summary>
        [JsonProperty("users_count")]
        public int? UsersCount { get; set; }

        /// <summary>
        /// Is it an important message
        /// </summary>
        [JsonProperty("important")]
        public int? Important { get; set; }

        /// <summary>
        /// Message text
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Information whether the message is outcoming
        /// </summary>
        [JsonProperty("out")]
        public int? Out { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<MessageAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("chat_active")]
        public IEnumerable<int?> ChatActive { get; set; }

        /// <summary>
        /// Chat action type (or null if none type)
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Chat text (for chat_create and chat_title_update)
        /// </summary>
        [JsonProperty("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// User if (for chat_invite_user or chat_kick_user)
        /// </summary>
        [JsonProperty("action_mid")]
        public int? ActionMid { get; set; }
    }
}