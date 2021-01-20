using System;
using System.Collections.Generic;
using Data.Models;

namespace Data.SeedData
{
    public static class SeedingData
    {

        public static IEnumerable<Car> Cars()
        {
            return new List<Car>
            {
                new Car
                {
                    Id = Guid.NewGuid(),
                    Owner = "Michael Barks",
                    Description = "This is my favorite car",
                    Brand = new Brand
                    {
                        Id = Guid.NewGuid(),
                        Country = "Germany",
                        Name = "Mercedes Benz"
                    },
                    Model = new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "E-Class"
                    },
                    Year = 2020
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Owner = "Robert Siu",
                    Description = "My Sport Car",
                    Brand = new Brand
                    {
                        Id = Guid.NewGuid(),
                        Country = "USA",
                        Name = "Dodge"
                    },
                    Model = new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Viper"
                    },
                    Year = 2018
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Owner = "Laura Swartz",
                    Description = "Weekend Car",
                    Brand = new Brand
                    {
                        Id = Guid.NewGuid(),
                        Country = "USA",
                        Name = "GMC"
                    },
                    Model = new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Yukon"
                    },
                    Year = 2015
                }
            };
        }
    }
}
