using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Xbox X", Price = 750},
            new Product(){Name = "Nintendo Switch", Price = 350},
            new Product(){Name = "Playstation 5", Price = 800},
            new Product(){Name = "Atari", Price = 200},
            new Product(){Name = "Sega Genesis", Price = 150}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQL database.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL database.");
        }
    }
}
