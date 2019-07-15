using Microsoft.EntityFrameworkCore;
using PressPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay
{
    public class SiteContext : DbContext 

    {
        public DbSet<Artist> Artists { get; set; } 




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=PressPlay;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
                          //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    ArtistName = "J Cole",
                    ImageUrl = "/images/JCole.jpg/",
                },
                new Artist
                {
                    ArtistId = 2,
                    ArtistName = "Ariana Grande",
                    ImageUrl = "/images/ArianaGrande.jpg/",
                },
                new Artist
                {
                    ArtistId = 3,
                    ArtistName = "Pink",
                    ImageUrl = "/images/Pink.jpg/",
                },
                new Artist
                {
                    ArtistId = 4,
                    ArtistName = "Megadeth",
                    ImageUrl = "/images/Megadeth.jpg",
                });

        }
    }
}
