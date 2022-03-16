using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WatchList.Logic.Models;

namespace WatchList.Logic.Database
{
    public class WatchListDbContext : DbContext
    {
        public DbSet<Show> Shows { get; set; } //Set up DbSet properties
        public DbSet<Season> Seasons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Instructions on which Database to use during configuration
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WatchListDB");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder) //Remove contraints for deleting objects from database so as to avoid bugs
        {
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
