using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

/// <summary>
/// An entity set typically corresponds to a database table. 
/// An entity corresponds to a row in the table.
/// </summary>
namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddInitialData();
            //Console.WriteLine($"OnModelCreating(ModelBuilder {modelBuilder})");
            //Console.WriteLine($"OnModelCreating(Model {modelBuilder.Model})");
            //modelBuilder.Entity<User>().HasData(new User { Id = 100, FirstName = "Hong", LastName = "Song", Password = "song2000", UserName = "hongsong" },
            //                                    new User { Id = 101, FirstName = "Song", LastName = "Soft", Password = "song2000", UserName = "songsoft" });
            //Console.WriteLine($"OnModelCreating(Model {modelBuilder.Model})");
            //modelBuilder.Entity<Tweet>().HasData(new Tweet { Id = 1000, Content = "Initial empty", ParentId = 0, CreateDate = DateTime.Now, Type="TEST" });
        }

        // Called to save changes by create and edit, etc.
        //      _context.SaveChanges();
        //public override int SaveChanges()
        //{
        //    return 0;
        //}
    }
}
