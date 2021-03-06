using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Audio
{
    /// <summary>
    /// API AudioFull object.
    /// </summary>
    public class AudioFull : Audio
    {
        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// Date when uploaded
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Lyrics ID
        /// </summary>
        [JsonProperty("lyrics_id")]
        public int? LyricsId { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Information whether the audio is hidden from search
        /// </summary>
        [JsonProperty("no_search")]
        public int? NoSearch { get; set; }

        /// <summary>
        /// Genre ID
        /// </summary>
        [JsonProperty("genre_id")]
        public int? GenreId { get; set; }
    }
}