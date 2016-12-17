using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Stats API section.
    /// </summary>
    public class Stats
    {
        private Vkontakte _vkontakte;

        internal Stats(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns statistics of a community or an application.
        /// Docs: <see href="https://vk.com/dev/stats.get">stats.get</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="app_id">Application ID.</param>
        /// <param name="date_from">Latest datestamp (in Unix time) of statistics to return.</param>
        /// <param name="date_to">End datestamp (in Unix time) of statistics to return.</param>
        public async Task<object> Get(int? group_id = null, int? app_id = null, string date_from = null, string date_to = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (app_id != null)
                parameters.Add("app_id", app_id.ToString());
            if (date_from != null)
                parameters.Add("date_from", date_from);
            if (date_to != null)
                parameters.Add("date_to", date_to);

            return await _vkontakte.GetAsync<object>("stats.get", parameters);
        }

        /// <summary>
        /// 
        /// Docs: <see href="https://vk.com/dev/stats.trackVisitor">stats.trackVisitor</see>
        /// </summary>
        public async Task<object> TrackVisitor()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<object>("stats.trackVisitor", parameters);
        }

        /// <summary>
        /// Returns stats for a wall post.
        /// Docs: <see href="https://vk.com/dev/stats.getPostReach">stats.getPostReach</see>
        /// </summary>
        /// <param name="owner_id">post owner community id. Specify with "-" sign.</param>
        /// <param name="post_id">wall post id. Note that stats are available only for '300' last (newest) posts on a community wall.</param>
        public async Task<object> GetPostReach(int? owner_id = null, int? post_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());

            return await _vkontakte.GetAsync<object>("stats.getPostReach", parameters);
        }

    }
}
