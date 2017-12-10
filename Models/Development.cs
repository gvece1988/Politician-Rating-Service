using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Politician_Rating.Service.Models
{
    public class Development
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Activity { get; set; }
        public string State { get; set; }
        public double Budget { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public Candidate Candidate { get; set; }

        public Rating Rating { get; set; }
    }
}