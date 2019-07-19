using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class NewSeedData : Migration
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
                    { 4, "Megadeth", "https://images.wallpaperscraft.com/image/megadeth_hair_jackets_graphics_tie_6137_1280x720.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "AlbumTitle", "ArtistId", "ImageUrl", "RecordLabel" },
                values: new object[,]
                {
                    { 1, "KOD", 1, "https://media.pitchfork.com/photos/5ad8b39b5fadaa7e89cfd808/2:1/w_1000/KOD%20J.%20Cole.jpg", "DreamVille" },
                    { 2, "Sweetener", 2, "https://www.udiscovermusic.com/wp-content/uploads/2018/06/Ariana-Grande-No-Tears-Left-To-Cry-packshot-cropped-web-optimised-1000.jpg", "Republic Records" },
                    { 3, "missundaztood", 3, "https://images-na.ssl-images-amazon.com/images/I/81GGshIlE4L._SL1200_.jpg", "Arista Records" },
                    { 4, "Rust In Peace", 4, "https://i.ytimg.com/vi/SW6uObWJRH4/maxresdefault.jpg", "Capitol Records" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "Duration", "Link", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1, 132, "https://www.youtube.com/watch?v=2hMy0rnHQv0", "Motiv8" },
                    { 2, 2, 182, "https://www.youtube.com/watch?v=-_aGvdfLTKY", "Nasa" },
                    { 3, 3, 191, "https://www.youtube.com/watch?v=mW1dbiD_zDk", "Get the Party Started" },
                    { 4, 4, 299, "https://www.youtube.com/watch?v=Lcm9qqo_qB0", "Tornado of Souls" }
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
