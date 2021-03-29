using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDatabaseProject.Models
{
    public class ShowContext:DbContext
    {
        public ShowContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            { Id = 1, Name = "Robert", Description = "Action movie", Duration = 120.0f });
        }
    }
}
