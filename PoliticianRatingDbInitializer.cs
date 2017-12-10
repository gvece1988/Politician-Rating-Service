using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Politician_Rating.Service.Models;

namespace Politician_Rating.Service
{
    public class PoliticianRatingDbInitializer : DropCreateDatabaseIfModelChanges<PoliticianRatingContext>
    {
        protected override void Seed(PoliticianRatingContext context)
        {
            context.Parties.AddRange(new[] { new Party { Name = "DMK" }, new Party { Name = "ADMK" } });

            base.Seed(context);
        }
    }
}