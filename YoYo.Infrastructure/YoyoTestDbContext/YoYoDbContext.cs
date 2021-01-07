using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Infrastructure.YoyoTestDbContext
{
    /// <summary>
    ///  YoYo DbContext Class for uisng EF core 
    /// </summary>
    public class YoYoDbContext : DbContext
    {

        public YoYoDbContext(DbContextOptions<YoYoDbContext> options)
            : base(options)
        {
        }

        public DbSet<FitnessTest> FitnessTests { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Shuttle> Shuttles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>().ToTable("Person");
        //    modelBuilder.Entity<FitnessTest>().ToTable("FitnessTest");
        //    modelBuilder.Entity<Shuttle>().ToTable("Shuttle");
        //}
    }
}
