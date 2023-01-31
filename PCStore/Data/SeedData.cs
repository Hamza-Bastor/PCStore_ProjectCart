using Microsoft.EntityFrameworkCore;
using PCStore.Models;

namespace PCStore.Data
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category computers = new Category { Name = "Computers", Slug = "computers" };
                Category hardware = new Category { Name = "Hardware", Slug = "hardware" };
                Category peripherals = new Category { Name = "Peripherals", Slug = "peripherals" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "AMD Ryzen 9 7950X RTX 4080 16GB",
                            Slug = "AMD Ryzen 9 7950X RTX 4080 16GB",
                            Description = "Assembled Full Tower PC",
                            Price = 54000M,
                            Category = computers,
                            Image = "PC-Assembled-Gaming1.png"
                        },
                        new Product
                        {
                            Name = "i9-13900K RTX 4080 16GB",
                            Slug = "i9-13900K RTX 4080 16GB",
                            Description = "Assembled Full Tower PC",
                            Price = 53000M,
                            Category = computers,
                            Image = "PC-Assembled-Gaming2.png"
                        },
                        new Product
                        {
                            Name = "i7-13700K RTX 3070Ti 8GB",
                            Slug = "i7-13700K RTX 3070Ti 8GB",
                            Description = "Assembled Full Tower PC",
                            Price = 31000M,
                            Category = computers,
                            Image = "PC-Assembled-Gaming3.png"
                        },
                        new Product
                        {
                            Name = "Gigabyte RTX 4090",
                            Slug = "Gigabyte RTX 4090",
                            Description = "nVidia RTX 4090 24 GB",
                            Price = 31000M,
                            Category = hardware,
                            Image = "Hardware1.png"
                        },
                        new Product
                        {
                            Name = "Kingston Fury Beast",
                            Slug = "Kingston Fury Beast",
                            Description = "DDR4 64 GB",
                            Price = 5100M,
                            Category = hardware,
                            Image = "Hardware2.png"
                        },
                        new Product
                        {
                            Name = "G.Skill Trident",
                            Slug = "G.Skill Trident",
                            Description = "DDR5 32GB",
                            Price = 3700M,
                            Category = hardware,
                            Image = "Hardware3.png"
                        },
                        new Product
                        {
                            Name = "WD HDD Gold",
                            Slug = "WD HDD Gold",
                            Description = "12TB",
                            Price = 6000M,
                            Category = hardware,
                            Image = "Hardware4.png"
                        },
                        new Product
                        {
                            Name = "Intel Core I9-12900KS",
                            Slug = "Intel Core I9-12900KS",
                            Description = "5.10 GHz, 16 Core",
                            Price = 11000M,
                            Category = hardware,
                            Image = "Hardware5.png"
                        },
                        new Product
                        {
                            Name = "AMD Ryzen 9 7950X",
                            Slug = "AMD Ryzen 9 7950X",
                            Description = "5.70GHz, 16Core",
                            Price = 9500M,
                            Category = hardware,
                            Image = "Hardware6.png"
                        },
                        new Product
                        {
                            Name = "Cooler Master SK622",
                            Slug = "Cooler Master SK622",
                            Description = "USB Type-C +Bluetooth 4.0",
                            Price = 1800M,
                            Category = peripherals,
                            Image = "peripheral1.png"
                        },
                        new Product
                        {
                            Name = "Logitech Lightspeed",
                            Slug = "Logitech Lightspeed",
                            Description = "Wireless Mouse",
                            Price = 1600M,
                            Category = peripherals,
                            Image = "peripheral2.png"
                        },
                        new Product
                        {
                            Name = "Logitech G G733",
                            Slug = "Logitech G G733",
                            Description = "Ultra Lightweight",
                            Price = 2100M,
                            Category = peripherals,
                            Image = "peripheral3.png"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}