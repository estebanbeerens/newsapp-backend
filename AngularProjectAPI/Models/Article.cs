using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularProjectAPI.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ShortSummary { get; set; }
        public string Body { get; set; }

        //Relations
        public int TagID { get; set; }
        [JsonIgnore]
        public Tag Tag { get; set; }
        public int UserID { get; set; }
        [JsonIgnore]
        public User User { get; set; } //Creator
        public int ArticleStatusID { get; set; }
        [JsonIgnore]
        public ArticleStatus ArticleStatus { get; set; }
        [JsonIgnore]
        public ICollection<Like> Likes { get; set; }
        [JsonIgnore]
        public ICollection<Comment> Comments { get; set; }
    }
}
