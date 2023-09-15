using BulkeyModels.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyDataAccess_DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Catagory> catagories = new List<Catagory>()
          {
              new Catagory
              {
                  ID = Guid.Parse("7469fc0c-9c23-48a7-8909-7c678243e786"),
                  Name="Action",
                  DisplayOrder=1
              },
               new Catagory
              {
                  ID = Guid.Parse("c81c000c-41c0-41b4-8c34-561bee24bea9"),
                  Name="SciFi",
                  DisplayOrder=2
              },
               new Catagory
               {
                   ID=Guid.Parse("f36a0935-38b6-4721-86f1-d8eb43f45279"),
                   Name = "History",
                   DisplayOrder=3
               }
          };

            modelBuilder.Entity<Catagory>().HasData(catagories);

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = Guid.Parse("9df7fd61-2250-48f2-b967-eb40c3119ece"),
                  Title = "Fortune of Time",
                  Author = "Billy Spark",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "SWD9999001",
                  ListPrice = 99,
                  Price = 90,
                  Price50 = 85,
                  Price100 = 80,
                  CatagoryId= Guid.Parse("f36a0935-38b6-4721-86f1-d8eb43f45279")

              },
              new Product
              {
                  Id = Guid.Parse("a93fa671-10cd-4bb9-9fca-66dcce7f9c9e"),
                  Title = "Dark Skies",
                  Author = "Nancy Hoover",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "CAW777777701",
                  ListPrice = 40,
                  Price = 30,
                  Price50 = 25,
                  Price100 = 20,
                  CatagoryId= Guid.Parse("f36a0935-38b6-4721-86f1-d8eb43f45279"),

              },
              new Product
              {
                  Id = Guid.Parse("1da8ed6b-9197-4f15-a45f-13dd2cae73ee"),
                  Title = "Vanish in the Sunset",
                  Author = "Julian Button",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "RITO5555501",
                  ListPrice = 55,
                  Price = 50,
                  Price50 = 40,
                  Price100 = 35,
                  CatagoryId= Guid.Parse("c81c000c-41c0-41b4-8c34-561bee24bea9")

              },
              new Product
              {
                  Id = Guid.Parse("789f4897-2186-447b-a084-8a6a2b377579"),
                  Title = "Cotton Candy",
                  Author = "Abby Muscles",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "WS3333333301",
                  ListPrice = 70,
                  Price = 65,
                  Price50 = 60,
                  Price100 = 55,
                  CatagoryId = Guid.Parse("c81c000c-41c0-41b4-8c34-561bee24bea9")
              },
              new Product
              {
                  Id = Guid.Parse("f942dadd-44e9-4c64-a176-f30c7f5fbdb5"),
                  Title = "Rock in the Ocean",
                  Author = "Ron Parker",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "SOTJ1111111101",
                  ListPrice = 30,
                  Price = 27,
                  Price50 = 25,
                  Price100 = 20,
                  CatagoryId= Guid.Parse("f36a0935-38b6-4721-86f1-d8eb43f45279")

              },
              new Product
              {
                  Id = Guid.Parse("1f0d0d02-b210-4ccb-9478-48ac03e90dda"),
                  Title = "Leaves and Wonders",
                  Author = "Laura Phantom",
                  Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                  ISBN = "FOT000000001",
                  ListPrice = 25,
                  Price = 23,
                  Price50 = 22,
                  Price100 = 20,
                 CatagoryId= Guid.Parse("f36a0935-38b6-4721-86f1-d8eb43f45279")
              }
              );
        }
    }

}

    



