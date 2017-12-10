using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Politician_Rating.Service.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}