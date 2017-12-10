using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Politician_Rating.Service.Models;

namespace Politician_Rating.Service
{
    public class PoliticianRatingContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Development>().HasOptional(m => m.Rating).WithRequired(t => t.Development);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Party> Parties { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Development> Developments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}