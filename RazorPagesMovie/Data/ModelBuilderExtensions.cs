using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Data
{
    public static class ModelBuilderExtensions
    {

        public static void AddInitialData(this ModelBuilder modelBuilder)
        {
            Console.WriteLine("AddInitialData ......");
            Console.WriteLine($"ModelBuilder {modelBuilder}");
            Console.WriteLine($"Model {modelBuilder.Model}");
            try
            {
                Console.WriteLine($"OnModelCreating(Model {modelBuilder.Model})");
                var r1 = modelBuilder.Entity<Movie>().HasData(new Movie { ID = 1000, Title = "Initial empty", Genre = "-", Price = 0.0m });

                System.Diagnostics.Debug.WriteLine($"r1 ${r1.GetType()} {r1}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: ${ex}");
            }


        }
    }
}
