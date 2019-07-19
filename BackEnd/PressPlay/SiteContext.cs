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

        public DbSet<Album> Album { get; set; }

        public DbSet<Song> Song { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=PressPlay;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    ArtistName = "J Cole",
                    ImageUrl = "https://i.ytimg.com/vi/UhD66RY3jt4/maxresdefault.jpg",
                },
                new Artist
                {
                    ArtistId = 2,
                    ArtistName = "Ariana Grande",
                    ImageUrl = "https://www.androidred.com/wp-content/uploads/2019/01/Ariana-Grande-Special-background.jpg",
                },
                new Artist
                {
                    ArtistId = 3,
                    ArtistName = "Pink",
                    ImageUrl = "https://ewscripps.brightspotcdn.com/dims4/default/ad6bfcf/2147483647/strip/true/crop/640x360+0+60/resize/1280x720!/quality/90/?url=https%3A%2F%2Fsharing.wxyz.com%2Fsharescnn%2Fphoto%2F2018%2F08%2F23%2FGettyImages-1000155580_1535076197337_95575003_ver1.0_640_480.jpg",
                },
                new Artist
                {
                    ArtistId = 4,
                    ArtistName = "Megadeth",
                    ImageUrl = "https://images.wallpaperscraft.com/image/megadeth_hair_jackets_graphics_tie_6137_1280x720.jpg",
                });

            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    AlbumTitle = "KOD",
                    ImageUrl = "https://media.pitchfork.com/photos/5ad8b39b5fadaa7e89cfd808/2:1/w_1000/KOD%20J.%20Cole.jpg",
                    RecordLabel = "DreamVille",
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 2,
                    AlbumTitle = "Sweetener",
                    ImageUrl = "https://www.udiscovermusic.com/wp-content/uploads/2018/06/Ariana-Grande-No-Tears-Left-To-Cry-packshot-cropped-web-optimised-1000.jpg",
                    RecordLabel = "Republic Records",
                    ArtistId = 2
                },
                new Album
                {
                    AlbumId = 3,
                    AlbumTitle = "missundaztood",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81GGshIlE4L._SL1200_.jpg",
                    RecordLabel = "Arista Records",
                    ArtistId = 3

                },
                new Album
                {
                    AlbumId = 4,
                    AlbumTitle = "Rust In Peace",
                    ImageUrl = "https://i.ytimg.com/vi/SW6uObWJRH4/maxresdefault.jpg",
                    RecordLabel = "Capitol Records",
                    ArtistId = 4

                });

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    SongTitle = "Motiv8",
                    Link = "https://www.youtube.com/watch?v=2hMy0rnHQv0",
                    Duration = 132,
                    AlbumId = 1,
                },
                new Song
                {
                    SongId = 2,
                    SongTitle = "Nasa",
                    Link = "https://www.youtube.com/watch?v=-_aGvdfLTKY",
                    Duration = 182,
                    AlbumId = 2,
                },
                new Song
                {
                    SongId = 3,
                    SongTitle = "Get the Party Started",
                    Link = "https://www.youtube.com/watch?v=mW1dbiD_zDk",
                    Duration = 191,
                    AlbumId = 3,
                },
                new Song
                {
                    SongId = 4,
                    SongTitle = "Tornado of Souls",
                    Link = "https://www.youtube.com/watch?v=Lcm9qqo_qB0",
                    Duration = 299,
                    AlbumId = 4,
                });
        }

        
    }
}
