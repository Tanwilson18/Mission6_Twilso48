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
        public DbSet<applicationResponse> response { get; set; }

        protected override void onModelCreating(ModelBuilder mb)
        {
            mb.Entity<applicationResponse>().HasData(
                new applicationResponse
                {
                    MovieId = 1,
                    Name = "Tanner",
                    LastName = "Wilson",
                    age = 55,
                    phone = "888-888-8888",
                    Major = "is",
                    Stalker = false

                }
                );
        }

    }
}
