using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Politician_Rating.Service.Models;

namespace Politician_Rating.Service.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PartyController : ApiController
    {
        [HttpGet]
        public List<Party> GetParties()
        {
            using (var context = new PoliticianRatingContext())
            {
                return context.Parties.ToList();
            }
        }

        [HttpPost]
        public void SaveParty([FromBody]Party party)
        {
            using (var context = new PoliticianRatingContext())
            {
                context.Parties.Add(party);
                context.SaveChanges();
            }
        }
    }
}