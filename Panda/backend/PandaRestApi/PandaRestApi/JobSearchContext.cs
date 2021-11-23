using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PandaRestApi
{
    public class JobSearchContext : DbContext
    {
        public DbSet<Job> Test_Jobs { get; set; }
        public DbSet<JobTitle> Test_JobTitles { get; set; }

        public DbSet<JobView> Jobs_view { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=ROZA-WIN10;Initial Catalog=TestDataBase;Integrated Security=True
            optionsBuilder.UseSqlServer(@"Data Source=ROZA-WIN10;Initial Catalog=TestDataBase;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobView>()
                .HasNoKey();
        }

    }
}
