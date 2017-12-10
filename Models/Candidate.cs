using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Politician_Rating.Service.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Party Party { get; set; }

        public ICollection<Development> Developments { get; set; }
    }
}