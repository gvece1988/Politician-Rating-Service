using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Politician_Rating.Service.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public Development Development { get; set; }
    }
}