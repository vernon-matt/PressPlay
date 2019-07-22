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
                },
                new Artist
                {
                    ArtistId = 5,
                    ArtistName = "Luke Bryan",
                    ImageUrl = "https://www.soundslikenashville.com/wp-content/uploads/2015/02/Luke-Bryan-CountryMusicIsLove-e1423094611227.jpg",
                },
                new Artist
                {
                    ArtistId = 6,
                    ArtistName = "Drake",
                    ImageUrl = "https://imagez.tmz.com/image/19/1by1/2018/05/03/1906e3b396275292a9534593c61c5b50_xl.jpg",
                },
                new Artist
                {
                    ArtistId = 7,
                    ArtistName = "Beyoncé",
                    ImageUrl = "https://scontent-iad3-1.cdninstagram.com/vp/4915b3050db5904c61951f5495b41865/5DD178F6/t51.2885-15/e35/p1080x1080/65976770_471763230292454_4961231059076823417_n.jpg?_nc_ht=scontent-iad3-1.cdninstagram.com",
                },
                new Artist
                {
                    ArtistId = 8,
                    ArtistName = "Luke Combs",
                    ImageUrl = "https://www.billboard.com/files/styles/article_main_image/public/media/Luke-Combs-bb14-2019-feat-billboard-bfhukopz-1548.jpg",
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

                },
                new Album
                {
                    AlbumId = 5,
                    AlbumTitle = "Play It Again",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Play_It_Again.jpg/220px-Play_It_Again.jpg",
                    RecordLabel = "Capitol Nashville",
                    ArtistId = 5,
                },
                new Album
                {
                    AlbumId = 6,
                    AlbumTitle = "Views",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/af/Drake_-_Views_cover.jpg",
                    RecordLabel = "Cash Money, Republic, Young Money",
                    ArtistId = 6,
                },
                new Album
                {
                    AlbumId = 7,
                    AlbumTitle = "Lemonade",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/53/Beyonce_-_Lemonade_%28Official_Album_Cover%29.png",
                    RecordLabel = "Parkwood, Columbia",
                    ArtistId = 7,
                },
                new Album
                {
                    AlbumId = 8,
                    AlbumTitle = "This One's for You",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5a/Combs_this_one.jpg",
                    RecordLabel = "River House Artists, Columbia Nashville",
                    ArtistId = 8,
                },
                new Album
                {
                    AlbumId = 9,
                    AlbumTitle = "Born Sinner",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/J_Cole_Born_Sinner1.jpg",
                    RecordLabel = "ByStorm, Columbia, Dreamville, Roc Nation",
                    ArtistId = 1,
                },
                new Album
                {
                    AlbumId = 10,
                    AlbumTitle = "Dangerous Woman",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Ariana_Grande_-_Dangerous_Woman_%28Official_Album_Cover%29.png",
                    RecordLabel = "	Republic",
                    ArtistId = 2,
                },
                new Album
                {
                    AlbumId = 11,
                    AlbumTitle = "Beautiful Trauma",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8c/PINK_-_Beautiful_Trauma_%28Official_Album_Cover%29.png",
                    RecordLabel = "RCA",
                    ArtistId = 3,
                },
                new Album
                {
                    AlbumId = 12,
                    AlbumTitle = "Countdown to Extinction",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Countdown_album_cover.jpg",
                    RecordLabel = "Capitol",
                    ArtistId = 4,
                },
                new Album
                {
                    AlbumId = 13,
                    AlbumTitle = "Kill the Lights",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Kill_the_Lights.jpg",
                    RecordLabel = "Capitol Nashville",
                    ArtistId = 5,
                },
                new Album
                {
                    AlbumId = 14,
                    AlbumTitle = "Take Care",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ae/Drake_-_Take_Care_cover.jpg",
                    RecordLabel = "Young Money, Cash Money, Republic",
                    ArtistId = 6,
                },
                new Album
                {
                    AlbumId = 15,
                    AlbumTitle = "4",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/ca/Beyonc%C3%A9_-_4.png",
                    RecordLabel = "Parkwood, Columbia",
                    ArtistId = 7,
                },
                new Album
                {
                    AlbumId = 16,
                    AlbumTitle = "The Prequel",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/40/Luke_Combs_-_The_Prequel.png",
                    RecordLabel = "River House Artists, Columbia Nashville",
                    ArtistId = 8,
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
                },
                new Song
                {
                    SongId = 5,
                    SongTitle = "No Tears Left to Cry",
                    Link = "https://www.youtube.com/watch?v=nNcDkT_AoHQ",
                    Duration = 206,
                    AlbumId = 2,
                },
                new Song
                {
                    SongId = 6,
                    SongTitle = "God Is a Woman",
                    Link = "https://www.youtube.com/watch?v=kHLHSlExFis",
                    Duration = 197,
                    AlbumId = 2,
                },
                new Song
                {
                    SongId = 7,
                    SongTitle = "Breathin",
                    Link = "https://www.youtube.com/watch?v=kN0iD0pI3o0",
                    Duration = 198,
                    AlbumId = 2,
                },
                new Song
                {
                    SongId = 8,
                    SongTitle = "ATM",
                    Link = "https://www.youtube.com/watch?v=ew7qhDBQcU4",
                    Duration = 216,
                    AlbumId = 1,
                },
                new Song
                {
                    SongId = 9,
                    SongTitle = "Photograph",
                    Link = "https://www.youtube.com/watch?v=tIRi44nVNCA",
                    Duration = 218,
                    AlbumId = 1,
                },
                new Song
                {
                    SongId = 10,
                    SongTitle = "Don't Let Me Get Me",
                    Link = "https://www.youtube.com/watch?v=K_t9AA3Z4PE",
                    Duration = 210,
                    AlbumId = 3,
                },
                new Song
                {
                    SongId = 11,
                    SongTitle = "Just like a Pill",
                    Link = "https://www.youtube.com/watch?v=JDKGWaCglRM",
                    Duration = 237,
                    AlbumId = 3,
                },
                new Song
                {
                    SongId = 12,
                    SongTitle = "Family Portrait",
                    Link = "https://www.youtube.com/watch?v=eZbj_caIAUE",
                    Duration = 298,
                    AlbumId = 3,
                },
                new Song
                {
                    SongId = 13,
                    SongTitle = "Holy Wars... The Punishment Due",
                    Link = "https://www.youtube.com/watch?v=9d4ui9q7eDM",
                    Duration = 392,
                    AlbumId = 4,
                },
                new Song
                {
                    SongId = 14,
                    SongTitle = "Hangar 18",
                    Link = "https://www.youtube.com/watch?v=B-oU2xlViRQ",
                    Duration = 314,
                    AlbumId = 4,
                },
                new Song
                {
                    SongId = 15,
                    SongTitle = "Play It Again",
                    Link = "https://www.youtube.com/watch?v=ALV-QtDFpSw",
                    Duration = 227,
                    AlbumId = 5,
                },
                new Song
                {
                    SongId = 16,
                    SongTitle = "Hotline Bling",
                    Link = "https://www.youtube.com/watch?v=uxpDa-c-4Mc",
                    Duration = 267,
                    AlbumId = 6,
                },
                new Song
                {
                    SongId = 17,
                    SongTitle = "One Dance",
                    Link = "https://www.youtube.com/watch?v=iAbnEUA0wpA",
                    Duration = 174,
                    AlbumId = 6,
                },
                new Song
                {
                    SongId = 18,
                    SongTitle = "Pop Style",
                    Link = "https://www.youtube.com/watch?v=OJu4kkAbxHQ",
                    Duration = 209,
                    AlbumId = 6,
                },
                new Song
                {
                    SongId = 19,
                    SongTitle = "Controlla",
                    Link = "https://www.youtube.com/watch?v=PnL3sg-tq7s",
                    Duration = 245,
                    AlbumId = 6,
                },
                new Song
                {
                    SongId = 20,
                    SongTitle = "Formation",
                    Link = "https://www.youtube.com/watch?v=WDZJPJV__bQ",
                    Duration = 216,
                    AlbumId = 7,
                },
                new Song
                {
                    SongId = 21,
                    SongTitle = "Sorry",
                    Link = "https://www.youtube.com/watch?v=QxsmWxxouIM",
                    Duration = 232,
                    AlbumId = 7,
                },
                new Song
                {
                    SongId = 22,
                    SongTitle = "Hold Up",
                    Link = "https://www.youtube.com/watch?v=PeonBmeFR8o",
                    Duration = 221,
                    AlbumId = 7,
                },
                new Song
                {
                    SongId = 23,
                    SongTitle = "Hurricane",
                    Link = "https://www.youtube.com/watch?v=BixwVsiDdZM",
                    Duration = 223,
                    AlbumId = 8,
                },
                new Song
                {
                    SongId = 24,
                    SongTitle = "When It Rains It Pours",
                    Link = "https://www.youtube.com/watch?v=uXyxFMbqKYA",
                    Duration = 242,
                    AlbumId = 8,
                },
                new Song
                {
                    SongId = 25,
                    SongTitle = "One Number Away",
                    Link = "https://www.youtube.com/watch?v=Ct9BFr9XBaI",
                    Duration = 242,
                    AlbumId = 8,
                },
                new Song
                {
                    SongId = 26,
                    SongTitle = "She Got the Best of Me",
                    Link = "https://www.youtube.com/watch?v=a2a9fgPI_PI",
                    Duration = 183,
                    AlbumId = 8,
                },
                new Song
                {
                    SongId = 27,
                    SongTitle = "Power Trip",
                    Link = "https://www.youtube.com/watch?v=VMeirNg87AY",
                    Duration = 240,
                    AlbumId = 9,
                },
                new Song
                {
                    SongId = 28,
                    SongTitle = "Crooked Smile",
                    Link = "https://www.youtube.com/watch?v=eCxaXqwRhvw",
                    Duration = 279,
                    AlbumId = 9,
                },
                new Song
                {
                    SongId = 29,
                    SongTitle = "Forbidden Fruit",
                    Link = "https://www.youtube.com/watch?v=9-kWlUbkHS4",
                    Duration = 269,
                    AlbumId = 9,
                },
                new Song
                {
                    SongId = 30,
                    SongTitle = "She Knows",
                    Link = "https://www.youtube.com/watch?v=jYdaQJzcAcw",
                    Duration = 297,
                    AlbumId = 9,
                },
                new Song
                {
                    SongId = 31,
                    SongTitle = "Dangerous Woman",
                    Link = "https://www.youtube.com/watch?v=9WbCfHutDSE",
                    Duration = 235,
                    AlbumId = 10,
                },
                new Song
                {
                    SongId = 32,
                    SongTitle = "Into You",
                    Link = "https://www.youtube.com/watch?v=1ekZEVeXwek",
                    Duration = 244,
                    AlbumId = 10,
                },
                new Song
                {
                    SongId = 33,
                    SongTitle = "Side to Side",
                    Link = "https://www.youtube.com/watch?v=SXiSVQZLje8",
                    Duration = 226,
                    AlbumId = 10,
                },
                new Song
                {
                    SongId = 34,
                    SongTitle = "Everyday",
                    Link = "https://www.youtube.com/watch?v=LELFIuhSPCI",
                    Duration = 194,
                    AlbumId = 10,
                },
                new Song
                {
                    SongId = 35,
                    SongTitle = "What About Us",
                    Link = "https://www.youtube.com/watch?v=ClU3fctbGls",
                    Duration = 271,
                    AlbumId = 11,
                },
                new Song
                {
                    SongId = 36,
                    SongTitle = "Beautiful Trauma",
                    Link = "https://www.youtube.com/watch?v=EBt_88nxG4c",
                    Duration = 250,
                    AlbumId = 11,
                },
                new Song
                {
                    SongId = 37,
                    SongTitle = "Whatever You Want",
                    Link = "https://www.youtube.com/watch?v=xuAH21DkJow",
                    Duration = 243,
                    AlbumId = 11,
                },
                new Song
                {
                    SongId = 38,
                    SongTitle = "Secrets",
                    Link = "https://www.youtube.com/watch?v=gL20Eaeswfk",
                    Duration = 210,
                    AlbumId = 11,
                },
                new Song
                {
                    SongId = 39,
                    SongTitle = "Skin o' My Teeth",
                    Link = "https://www.youtube.com/watch?v=i1PceyvqBlg",
                    Duration = 194,
                    AlbumId = 12,
                },
                new Song
                {
                    SongId = 40,
                    SongTitle = "Symphony of Destruction",
                    Link = "https://www.youtube.com/watch?v=wEPKIulCEhQ",
                    Duration = 247,
                    AlbumId = 12,
                },
                new Song
                {
                    SongId = 41,
                    SongTitle = "Foreclosure of a Dream",
                    Link = "https://www.youtube.com/watch?v=GIAu9xQp-zo",
                    Duration = 0,
                    AlbumId = 12,
                },
                new Song
                {
                    SongId = 42,
                    SongTitle = "Sweating Bullets",
                    Link = "https://www.youtube.com/watch?v=aOnKCcjP8Qs",
                    Duration = 269,
                    AlbumId = 12,
                },
                new Song
                {
                    SongId = 43,
                    SongTitle = "Kick the Dust Up",
                    Link = "https://www.youtube.com/results?search_query=kick+the+dust-up",
                    Duration = 191,
                    AlbumId = 13,
                },
                new Song
                {
                    SongId = 44,
                    SongTitle = "Strip It Down",
                    Link = "https://www.youtube.com/watch?v=kY2pJsOZvc4",
                    Duration = 241,
                    AlbumId = 13,
                },
                new Song
                {
                    SongId = 45,
                    SongTitle = "Home Alone Tonight",
                    Link = "https://www.youtube.com/watch?v=f2Exzqu2ocs",
                    Duration = 191,
                    AlbumId = 13,
                },
                new Song
                {
                    SongId = 46,
                    SongTitle = "Huntin', Fishin' and Lovin' Every Day",
                    Link = "https://www.youtube.com/results?search_query=huntin+fishin+and+lovin+everyday+lyrics",
                    Duration = 278,
                    AlbumId = 13,
                },
                new Song
                {
                    SongId = 47,
                    SongTitle = "The Motto",
                    Link = "https://www.youtube.com/watch?v=BYDKK95cpfM",
                    Duration = 182,
                    AlbumId = 14,
                },
                new Song
                {
                    SongId = 48,
                    SongTitle = "Marvins Room",
                    Link = "https://www.youtube.com/watch?v=JDb3ZZD4bA0",
                    Duration = 348,
                    AlbumId = 14,
                },
                new Song
                {
                    SongId = 49,
                    SongTitle = "Headlines",
                    Link = "https://www.youtube.com/watch?v=cimoNqiulUE",
                    Duration = 236,
                    AlbumId = 14,
                },
                new Song
                {
                    SongId = 50,
                    SongTitle = "Make Me Proud",
                    Link = "https://www.youtube.com/watch?v=AP6ps5CxgVk",
                    Duration = 220,
                    AlbumId = 14,
                },
                new Song
                {
                    SongId = 51,
                    SongTitle = "Run the World (Girls)",
                    Link = "https://www.youtube.com/watch?v=VBmMU_iwe6U",
                    Duration = 235,
                    AlbumId = 15,
                },
                new Song
                {
                    SongId = 52,
                    SongTitle = "Best Thing I Never Had",
                    Link = "https://www.youtube.com/watch?v=FHp2KgyQUFk",
                    Duration = 253,
                    AlbumId = 15,
                },
                new Song
                {
                    SongId = 53,
                    SongTitle = "Party",
                    Link = "https://www.youtube.com/watch?v=XWCwc1_sYMY",
                    Duration = 245,
                    AlbumId = 15,
                },
                new Song
                {
                    SongId = 54,
                    SongTitle = "Love on Top",
                    Link = "https://www.youtube.com/watch?v=Ob7vObnFUJc",
                    Duration = 267,
                    AlbumId = 15,
                },
                new Song
                {
                    SongId = 55,
                    SongTitle = "Beer Never Broke My Heart",
                    Link = "https://www.youtube.com/watch?v=7Lb9dq-JZFI",
                    Duration = 186,
                    AlbumId = 16,
                },
                new Song
                {
                    SongId = 56,
                    SongTitle = "Refrigerator Door",
                    Link = "https://www.youtube.com/watch?v=zeZVQOfkITU",
                    Duration = 204,
                    AlbumId = 16,
                },
                new Song
                {
                    SongId = 57,
                    SongTitle = "Even Though I'm Leaving",
                    Link = "https://www.youtube.com/watch?v=8bjo95QKD3c",
                    Duration = 225,
                    AlbumId = 16,
                },
                new Song
                {
                    SongId = 58,
                    SongTitle = "Lovin' on You",
                    Link = "https://www.youtube.com/watch?v=x3TBvI2AZKA",
                    Duration = 195,
                    AlbumId = 16,
                });
        }
    }
}