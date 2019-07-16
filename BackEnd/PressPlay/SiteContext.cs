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

            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    AlbumTitle = "KOD",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.vibe.com%2Ffiles%2F2018%2F04%2Fsixmau-j-cole-1524081746-650x366.png&imgrefurl=https%3A%2F%2Fwww.vibe.com%2F2018%2F04%2Fsixmau-j-cole-album-artwork&docid=DKGRHwn8XJ_J3M&tbnid=jcOT4-enJUjdzM%3A&vet=10ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw..i&w=650&h=366&bih=578&biw=1280&q=j%20cole%20kod&ved=0ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw&iact=mrc&uact=8",
                    RecordLabel = "DreamVille",
                },
                new Album
                {
                    AlbumId = 2,
                    AlbumTitle = "Thank you, Next",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fuproxx.files.wordpress.com%2F2019%2F01%2Fariana-grande-thank-u-next-Republic.jpg%3Fquality%3D100%26w%3D650&imgrefurl=https%3A%2F%2Fuproxx.com%2Fmusic%2Fariana-grande-thank-u-next-album%2F&docid=AT8lOUifI4pOEM&tbnid=9xaq0DBN3lGy2M%3A&vet=10ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ..i&w=650&h=360&bih=578&biw=1280&q=ariana%20grande%20thank%20u%20next%20album%20iage&ved=0ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ&iact=mrc&uact=8",
                    RecordLabel = "Matt",
                },
                new Album
                {
                    AlbumId = 3,
                    AlbumTitle = "missundaztood",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Ff%2Ffc%2FMisundazztodAlbum.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMissundaztood&docid=QSg0HS5C_zalQM&tbnid=sGzRB6THY0qn5M%3A&vet=10ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ..i&w=300&h=300&bih=578&biw=1280&q=pink%20missundaztood%20album&ved=0ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ&iact=mrc&uact=8",
                    RecordLabel = "Jenny",
                },
                new Album
                {
                    AlbumId = 4,
                    AlbumTitle = "Dystopia",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Ftownsquare.media%2Fsite%2F295%2Ffiles%2F2015%2F10%2FDystopiaTopofStory-628x630.jpg%3Fw%3D980%26q%3D75&imgrefurl=https%3A%2F%2Fultimateclassicrock.com%2Fmegadeth-dystopia-album%2F&docid=LebK_2-ytDo9kM&tbnid=s4H_o6BbYDqNQM%3A&vet=10ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ..i&w=980&h=983&bih=578&biw=1280&q=megadeth%20album%20covers&ved=0ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ&iact=mrc&uact=8",
                    RecordLabel = "Sergio",
                });

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    SongTitle = "Motiv8",
                    Link = "https://www.youtube.com/watch?v=2hMy0rnHQv0",
                    Duration = 132,
                    AlbumId = 1,
                    ArtistId = 1,
                },
                new Song
                {
                    SongId = 2,
                    SongTitle = "Nasa",
                    Link = "https://www.youtube.com/watch?v=-_aGvdfLTKY",
                    Duration = 182,
                    AlbumId = 2,
                    ArtistId = 2,
                },
                new Song
                {
                    SongId = 3,
                    SongTitle = "Get the Party Started",
                    Link = "https://www.youtube.com/watch?v=mW1dbiD_zDk",
                    Duration = 191,
                    AlbumId = 3,
                    ArtistId = 3,
                },
                new Song
                {
                    SongId = 4,
                    SongTitle = "Dystopia",
                    Link = "https://www.youtube.com/watch?v=bK95lWHl7js",
                    Duration = 299,
                    AlbumId = 4,
                    ArtistId = 4,
                });
        }

        public DbSet<PressPlay.Models.Album> Album { get; set; }
    }
}
