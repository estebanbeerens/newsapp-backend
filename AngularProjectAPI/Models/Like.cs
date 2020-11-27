using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngularProjectAPI.Models
{
    public class Like
    {
        public int LikeID { get; set; }

        //Relations
        public int ArticleID { get; set; }
        [JsonIgnore]
        public Article Article { get; set; }
        public int? UserID { get; set; }
        [JsonIgnore]
        public User User { get; set; } //Creator
    }
}
