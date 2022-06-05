
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this is because the method is override so first all that it has to do
            base.OnModelCreating(modelBuilder);

            //And then what I want:
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Rating>().ToTable("Rating");
        }
    }
}