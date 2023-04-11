
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder) 
        {
            List<Product> product = new List<Product>()
            {
                new Product()
                {
                    Id= 1,
                    Name="Carrot Cake",
                    Description= "Carrot Cake Any Description",
                    ImageName= "carrot_cake.jpg",
                    Price = 15.5m
                },
                new Product()
                {
                    Id= 2,
                    Name="Lemo Tart",
                    Description= "Lemo Tart Any Description",
                    ImageName= "lemon_tart.jpg",
                    Price = 10.5m
                },
                new Product()
                {
                    Id= 3,
                    Name="Cup Cakes",
                    Description= "Cup Cakes Any Description",
                    ImageName= "carrot_cake.jpg",
                    Price = 13m
                },
                new Product()
                {
                    Id= 4,
                    Name="New Cake",
                    Description= "New Carrot Cake Any Description",
                    ImageName= "cupcakes.jpg",
                    Price = 18m
                },
                new Product()
                {
                    Id= 5,
                    Name="Bread",
                    Description= "Bread Any Description",
                    ImageName= "bread.jpg",
                    Price = 12m
                },
                new Product()
                {
                    Id= 6,
                    Name="Chocolate Cake",
                    Description= "Chocolate Cake Any Description",
                    ImageName= "chocolate_cake.jpg",
                    Price = 16m
                },
                new Product()
                {
                    Id= 7,
                    Name="Pear Tart",
                    Description= "Pear Tart Any Description",
                    ImageName= "pear_tart.jpg",
                    Price = 15m
                },
                new Product()
                {
                    Id= 8,
                    Name="New Bread",
                    Description= "Bread Any Description",
                    ImageName= "bread.jpg",
                    Price = 20m
                }
            };

            modelBuilder.Entity<Product>().HasData(product);
        
            return modelBuilder;
        }
    }
}
