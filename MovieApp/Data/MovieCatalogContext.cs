using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class MovieCatalogContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<ActsIn> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = MovieAppData; Trusted_Connection = True; ");

        }




    }
}
