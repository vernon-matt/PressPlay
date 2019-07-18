using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class BestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumTitle = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    RecordLabel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumId);
                });

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
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SongTitle = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "AlbumTitle", "ImageUrl", "RecordLabel" },
                values: new object[,]
                {
                    { 1, "KOD", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.vibe.com%2Ffiles%2F2018%2F04%2Fsixmau-j-cole-1524081746-650x366.png&imgrefurl=https%3A%2F%2Fwww.vibe.com%2F2018%2F04%2Fsixmau-j-cole-album-artwork&docid=DKGRHwn8XJ_J3M&tbnid=jcOT4-enJUjdzM%3A&vet=10ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw..i&w=650&h=366&bih=578&biw=1280&q=j%20cole%20kod&ved=0ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw&iact=mrc&uact=8", "DreamVille" },
                    { 2, "Thank you, Next", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fuproxx.files.wordpress.com%2F2019%2F01%2Fariana-grande-thank-u-next-Republic.jpg%3Fquality%3D100%26w%3D650&imgrefurl=https%3A%2F%2Fuproxx.com%2Fmusic%2Fariana-grande-thank-u-next-album%2F&docid=AT8lOUifI4pOEM&tbnid=9xaq0DBN3lGy2M%3A&vet=10ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ..i&w=650&h=360&bih=578&biw=1280&q=ariana%20grande%20thank%20u%20next%20album%20iage&ved=0ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ&iact=mrc&uact=8", "Matt" },
                    { 3, "missundaztood", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Ff%2Ffc%2FMisundazztodAlbum.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMissundaztood&docid=QSg0HS5C_zalQM&tbnid=sGzRB6THY0qn5M%3A&vet=10ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ..i&w=300&h=300&bih=578&biw=1280&q=pink%20missundaztood%20album&ved=0ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ&iact=mrc&uact=8", "Jenny" },
                    { 4, "Dystopia", "https://www.google.com/imgres?imgurl=https%3A%2F%2Ftownsquare.media%2Fsite%2F295%2Ffiles%2F2015%2F10%2FDystopiaTopofStory-628x630.jpg%3Fw%3D980%26q%3D75&imgrefurl=https%3A%2F%2Fultimateclassicrock.com%2Fmegadeth-dystopia-album%2F&docid=LebK_2-ytDo9kM&tbnid=s4H_o6BbYDqNQM%3A&vet=10ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ..i&w=980&h=983&bih=578&biw=1280&q=megadeth%20album%20covers&ved=0ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ&iact=mrc&uact=8", "Sergio" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "J Cole", "JCole.jpg" },
                    { 2, "Ariana Grande", "/images/ArianaGrande.jpg/" },
                    { 3, "Pink", "/images/Pink.jpg/" },
                    { 4, "Megadeth", "/images/Megadeth.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "ArtistId", "Duration", "Link", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1, 1, 132, "https://www.youtube.com/watch?v=2hMy0rnHQv0", "Motiv8" },
                    { 2, 2, 2, 182, "https://www.youtube.com/watch?v=-_aGvdfLTKY", "Nasa" },
                    { 3, 3, 3, 191, "https://www.youtube.com/watch?v=mW1dbiD_zDk", "Get the Party Started" },
                    { 4, 4, 4, 299, "https://www.youtube.com/watch?v=bK95lWHl7js", "Dystopia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Song");
        }
    }
}
