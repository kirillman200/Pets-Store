using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using A1_200412952.Models;

namespace A1_200412952.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<A1_200412952.Models.PetFood> PetFood { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Animal>().HasData(
            new Models.Animal(1, "Labrador", "Big and cute"),
            new Models.Animal(2, "GIANT SCHNAUZER", "HUGE and has lots of hair") 

                );


            modelBuilder.Entity<PetFood>().HasData(
            new Models.PetFood() {Id = 1, Price = 10, Name = "Meat", Description = "Your pet will like it", NutritionalInformation = "It is probably healthy", Weight = 4, Brand = "NoName", ImageUrl = " ", AnimalId = 2  },
            new Models.PetFood() {Id = 2, Price = 1, Name = "Bone", Description = "It will last for 2 months", NutritionalInformation = "Just a bone", Weight = 1, Brand = "PetFoods", ImageUrl = " ",  AnimalId = 1  }

                );
        }

        public DbSet<A1_200412952.Models.Animal> Animal { get; set; }
    }
}
