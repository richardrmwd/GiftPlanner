using System;
using System.Collections.Generic;
using System.Text;
using Gift_Planner.Models;
using Microsoft.EntityFrameworkCore;

namespace Gift_Planner
{
    class Model: DbContext
    {
        public DbSet<Gift> Gift { get; set; }
        public DbSet<GiftIdea> GiftIdea { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Occasion> Occasion { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonOccasion> PersonOccasion { get; set; }
        public DbSet<Prefix> Prefix { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<Suffix> Suffix { get; set; }
    }
}
