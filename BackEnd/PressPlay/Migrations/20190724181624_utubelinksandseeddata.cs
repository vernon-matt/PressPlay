using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class utubelinksandseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtistName = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumTitle = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    RecordLabel = table.Column<string>(nullable: true),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Album_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SongTitle = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Song_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "J Cole", "https://i.ytimg.com/vi/UhD66RY3jt4/maxresdefault.jpg" },
                    { 2, "Ariana Grande", "https://www.androidred.com/wp-content/uploads/2019/01/Ariana-Grande-Special-background.jpg" },
                    { 3, "Pink", "https://ewscripps.brightspotcdn.com/dims4/default/ad6bfcf/2147483647/strip/true/crop/640x360+0+60/resize/1280x720!/quality/90/?url=https%3A%2F%2Fsharing.wxyz.com%2Fsharescnn%2Fphoto%2F2018%2F08%2F23%2FGettyImages-1000155580_1535076197337_95575003_ver1.0_640_480.jpg" },
                    { 4, "Megadeth", "https://images.wallpaperscraft.com/image/megadeth_hair_jackets_graphics_tie_6137_1280x720.jpg" },
                    { 5, "Luke Bryan", "https://www.soundslikenashville.com/wp-content/uploads/2015/02/Luke-Bryan-CountryMusicIsLove-e1423094611227.jpg" },
                    { 6, "Drake", "https://imagez.tmz.com/image/19/1by1/2018/05/03/1906e3b396275292a9534593c61c5b50_xl.jpg" },
                    { 7, "Beyoncé", "https://scontent-iad3-1.cdninstagram.com/vp/4915b3050db5904c61951f5495b41865/5DD178F6/t51.2885-15/e35/p1080x1080/65976770_471763230292454_4961231059076823417_n.jpg?_nc_ht=scontent-iad3-1.cdninstagram.com" },
                    { 8, "Luke Combs", "https://www.billboard.com/files/styles/article_main_image/public/media/Luke-Combs-bb14-2019-feat-billboard-bfhukopz-1548.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "AlbumTitle", "ArtistId", "ImageUrl", "RecordLabel" },
                values: new object[,]
                {
                    { 1, "KOD", 1, "https://media.pitchfork.com/photos/5ad8b39b5fadaa7e89cfd808/2:1/w_1000/KOD%20J.%20Cole.jpg", "DreamVille" },
                    { 9, "Born Sinner", 1, "https://upload.wikimedia.org/wikipedia/en/2/21/J_Cole_Born_Sinner1.jpg", "ByStorm, Columbia, Dreamville, Roc Nation" },
                    { 2, "Sweetener", 2, "https://www.udiscovermusic.com/wp-content/uploads/2018/06/Ariana-Grande-No-Tears-Left-To-Cry-packshot-cropped-web-optimised-1000.jpg", "Republic Records" },
                    { 10, "Dangerous Woman", 2, "https://upload.wikimedia.org/wikipedia/en/4/4b/Ariana_Grande_-_Dangerous_Woman_%28Official_Album_Cover%29.png", "	Republic" },
                    { 3, "missundaztood", 3, "https://images-na.ssl-images-amazon.com/images/I/81GGshIlE4L._SL1200_.jpg", "Arista Records" },
                    { 11, "Beautiful Trauma", 3, "https://upload.wikimedia.org/wikipedia/en/8/8c/PINK_-_Beautiful_Trauma_%28Official_Album_Cover%29.png", "RCA" },
                    { 4, "Rust In Peace", 4, "https://i.ytimg.com/vi/SW6uObWJRH4/maxresdefault.jpg", "Capitol Records" },
                    { 12, "Countdown to Extinction", 4, "https://upload.wikimedia.org/wikipedia/en/0/00/Countdown_album_cover.jpg", "Capitol" },
                    { 5, "Play It Again", 5, "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Play_It_Again.jpg/220px-Play_It_Again.jpg", "Capitol Nashville" },
                    { 13, "Kill the Lights", 5, "https://upload.wikimedia.org/wikipedia/en/8/8f/Kill_the_Lights.jpg", "Capitol Nashville" },
                    { 6, "Views", 6, "https://upload.wikimedia.org/wikipedia/en/a/af/Drake_-_Views_cover.jpg", "Cash Money, Republic, Young Money" },
                    { 14, "Take Care", 6, "https://upload.wikimedia.org/wikipedia/en/a/ae/Drake_-_Take_Care_cover.jpg", "Young Money, Cash Money, Republic" },
                    { 7, "Lemonade", 7, "https://upload.wikimedia.org/wikipedia/en/5/53/Beyonce_-_Lemonade_%28Official_Album_Cover%29.png", "Parkwood, Columbia" },
                    { 15, "4", 7, "https://upload.wikimedia.org/wikipedia/en/c/ca/Beyonc%C3%A9_-_4.png", "Parkwood, Columbia" },
                    { 8, "This One's for You", 8, "https://upload.wikimedia.org/wikipedia/en/5/5a/Combs_this_one.jpg", "River House Artists, Columbia Nashville" },
                    { 16, "The Prequel", 8, "https://upload.wikimedia.org/wikipedia/en/4/40/Luke_Combs_-_The_Prequel.png", "River House Artists, Columbia Nashville" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "Duration", "Link", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1, 132, "2hMy0rnHQv0", "Motiv8" },
                    { 43, 13, 191, "", "Kick the Dust Up" },
                    { 44, 13, 241, "kY2pJsOZvc4", "Strip It Down" },
                    { 45, 13, 191, "f2Exzqu2ocs", "Home Alone Tonight" },
                    { 46, 13, 278, "", "Huntin', Fishin' and Lovin' Every Day" },
                    { 16, 6, 267, "uxpDa-c-4Mc", "Hotline Bling" },
                    { 17, 6, 174, "iAbnEUA0wpA", "One Dance" },
                    { 18, 6, 209, "OJu4kkAbxHQ", "Pop Style" },
                    { 19, 6, 245, "PnL3sg-tq7s", "Controlla" },
                    { 47, 14, 182, "BYDKK95cpfM", "The Motto" },
                    { 48, 14, 348, "JDb3ZZD4bA0", "Marvins Room" },
                    { 49, 14, 236, "cimoNqiulUE", "Headlines" },
                    { 50, 14, 220, "AP6ps5CxgVk", "Make Me Proud" },
                    { 20, 7, 216, "WDZJPJV__bQ", "Formation" },
                    { 21, 7, 232, "QxsmWxxouIM", "Sorry" },
                    { 22, 7, 221, "PeonBmeFR8o", "Hold Up" },
                    { 51, 15, 235, "VBmMU_iwe6U", "Run the World (Girls)" },
                    { 52, 15, 253, "FHp2KgyQUFk", "Best Thing I Never Had" },
                    { 53, 15, 245, "XWCwc1_sYMY", "Party" },
                    { 54, 15, 267, "Ob7vObnFUJc", "Love on Top" },
                    { 23, 8, 223, "BixwVsiDdZM", "Hurricane" },
                    { 24, 8, 242, "uXyxFMbqKYA", "When It Rains It Pours" },
                    { 25, 8, 242, "Ct9BFr9XBaI", "One Number Away" },
                    { 26, 8, 183, "a2a9fgPI_PI", "She Got the Best of Me" },
                    { 55, 16, 186, "7Lb9dq-JZFI", "Beer Never Broke My Heart" },
                    { 56, 16, 204, "zeZVQOfkITU", "Refrigerator Door" },
                    { 15, 5, 227, "ALV-QtDFpSw", "Play It Again" },
                    { 42, 12, 269, "aOnKCcjP8Qs", "Sweating Bullets" },
                    { 41, 12, 0, "GIAu9xQp-zo", "Foreclosure of a Dream" },
                    { 40, 12, 247, "wEPKIulCEhQ", "Symphony of Destruction" },
                    { 8, 1, 216, "ew7qhDBQcU4", "ATM" },
                    { 9, 1, 218, "tIRi44nVNCA", "Photograph" },
                    { 27, 9, 240, "VMeirNg87AY", "Power Trip" },
                    { 28, 9, 279, "eCxaXqwRhvw", "Crooked Smile" },
                    { 29, 9, 269, "9-kWlUbkHS4", "Forbidden Fruit" },
                    { 30, 9, 297, "jYdaQJzcAcw", "She Knows" },
                    { 2, 2, 182, "-_aGvdfLTKY", "Nasa" },
                    { 5, 2, 206, "nNcDkT_AoHQ", "No Tears Left to Cry" },
                    { 6, 2, 197, "kHLHSlExFis", "God Is a Woman" },
                    { 7, 2, 198, "kN0iD0pI3o0", "Breathin" },
                    { 31, 10, 235, "9WbCfHutDSE", "Dangerous Woman" },
                    { 32, 10, 244, "1ekZEVeXwek", "Into You" },
                    { 57, 16, 225, "8bjo95QKD3c", "Even Though I'm Leaving" },
                    { 33, 10, 226, "SXiSVQZLje8", "Side to Side" },
                    { 3, 3, 191, "mW1dbiD_zDk", "Get the Party Started" },
                    { 10, 3, 210, "K_t9AA3Z4PE", "Don't Let Me Get Me" },
                    { 11, 3, 237, "JDKGWaCglRM", "Just like a Pill" },
                    { 12, 3, 298, "eZbj_caIAUE", "Family Portrait" },
                    { 35, 11, 271, "ClU3fctbGls", "What About Us" },
                    { 36, 11, 250, "EBt_88nxG4c", "Beautiful Trauma" },
                    { 37, 11, 243, "xuAH21DkJow", "Whatever You Want" },
                    { 38, 11, 210, "gL20Eaeswfk", "Secrets" },
                    { 4, 4, 299, "Lcm9qqo_qB0", "Tornado of Souls" },
                    { 13, 4, 392, "9d4ui9q7eDM", "Holy Wars... The Punishment Due" },
                    { 14, 4, 314, "B-oU2xlViRQ", "Hangar 18" },
                    { 39, 12, 194, "i1PceyvqBlg", "Skin o' My Teeth" },
                    { 34, 10, 194, "LELFIuhSPCI", "Everyday" },
                    { 58, 16, 195, "x3TBvI2AZKA", "Lovin' on You" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistId",
                table: "Album",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
