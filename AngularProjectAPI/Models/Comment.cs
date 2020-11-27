using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularProjectAPI.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Body { get; set; }

        //Relations
        public int ArticleID { get; set; }
        [JsonIgnore]
        public Article Article { get; set; }
        public int? UserID { get; set; }
        [JsonIgnore]
        public User User { get; set; } //Creator
    }
}
