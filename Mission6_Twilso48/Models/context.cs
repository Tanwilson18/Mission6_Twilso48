using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission6_Twilso48.Models
{
    public class context : DbContext 
    {
        //constructor 
        public context(DbContextOptions<context> options): base (options)
        {
        }
        public DbSet<applicationResponse> Responses { get; set; }
        public DbSet<Category> Category { get; set; }

        // seeding the database with data below
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Family" },
                new Category { CategoryID = 3, CategoryName = "Adventure" },
                new Category { CategoryID = 4, CategoryName = "Thriller" }


                );
             
            mb.Entity<applicationResponse>().HasData(
                new applicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Cars",
                    Year = 2006,
                    Director = "John Lasseter",
                    Rating = "G",
                    Notes = "Best Movie Ever"
                },
                new applicationResponse
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "007: No Time to Die",
                    Year = 2021,
                    Director = "Cary Joji Fukunaga",
                    Rating = "PG-13",
                    Notes = "Enough to make a man cry"
                },
                new applicationResponse
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Cars 2",
                    Year = 2011,
                    Director = "John Lasseter",
                    Rating = "G",
                    Notes = "Not as good as the first"
                }
                );
        }

    }
}
