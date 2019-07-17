using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class ArtistAlbumImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://media.pitchfork.com/photos/5ad8b39b5fadaa7e89cfd808/2:1/w_1000/KOD%20J.%20Cole.jpg");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 2,
                columns: new[] { "AlbumTitle", "ImageUrl", "RecordLabel" },
                values: new object[] { "Sweetener", "https://www.udiscovermusic.com/wp-content/uploads/2018/06/Ariana-Grande-No-Tears-Left-To-Cry-packshot-cropped-web-optimised-1000.jpg", "Republic Records" });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "RecordLabel" },
                values: new object[] { "https://images-na.ssl-images-amazon.com/images/I/81GGshIlE4L._SL1200_.jpg", "Arista Records" });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 4,
                columns: new[] { "AlbumTitle", "ImageUrl", "RecordLabel" },
                values: new object[] { "Rust In Peace", "https://i.ytimg.com/vi/SW6uObWJRH4/maxresdefault.jpg", "Capitol Records" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://i.ytimg.com/vi/UhD66RY3jt4/maxresdefault.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.androidred.com/wp-content/uploads/2019/01/Ariana-Grande-Special-background.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://ewscripps.brightspotcdn.com/dims4/default/ad6bfcf/2147483647/strip/true/crop/640x360+0+60/resize/1280x720!/quality/90/?url=https%3A%2F%2Fsharing.wxyz.com%2Fsharescnn%2Fphoto%2F2018%2F08%2F23%2FGettyImages-1000155580_1535076197337_95575003_ver1.0_640_480.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.wallpaperscraft.com/image/megadeth_hair_jackets_graphics_tie_6137_1280x720.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.vibe.com%2Ffiles%2F2018%2F04%2Fsixmau-j-cole-1524081746-650x366.png&imgrefurl=https%3A%2F%2Fwww.vibe.com%2F2018%2F04%2Fsixmau-j-cole-album-artwork&docid=DKGRHwn8XJ_J3M&tbnid=jcOT4-enJUjdzM%3A&vet=10ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw..i&w=650&h=366&bih=578&biw=1280&q=j%20cole%20kod&ved=0ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw&iact=mrc&uact=8");

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 2,
                columns: new[] { "AlbumTitle", "ImageUrl", "RecordLabel" },
                values: new object[] { "Thank you, Next", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fuproxx.files.wordpress.com%2F2019%2F01%2Fariana-grande-thank-u-next-Republic.jpg%3Fquality%3D100%26w%3D650&imgrefurl=https%3A%2F%2Fuproxx.com%2Fmusic%2Fariana-grande-thank-u-next-album%2F&docid=AT8lOUifI4pOEM&tbnid=9xaq0DBN3lGy2M%3A&vet=10ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ..i&w=650&h=360&bih=578&biw=1280&q=ariana%20grande%20thank%20u%20next%20album%20iage&ved=0ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ&iact=mrc&uact=8", "Matt" });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "RecordLabel" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Ff%2Ffc%2FMisundazztodAlbum.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMissundaztood&docid=QSg0HS5C_zalQM&tbnid=sGzRB6THY0qn5M%3A&vet=10ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ..i&w=300&h=300&bih=578&biw=1280&q=pink%20missundaztood%20album&ved=0ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ&iact=mrc&uact=8", "Jenny" });

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 4,
                columns: new[] { "AlbumTitle", "ImageUrl", "RecordLabel" },
                values: new object[] { "Dystopia", "https://www.google.com/imgres?imgurl=https%3A%2F%2Ftownsquare.media%2Fsite%2F295%2Ffiles%2F2015%2F10%2FDystopiaTopofStory-628x630.jpg%3Fw%3D980%26q%3D75&imgrefurl=https%3A%2F%2Fultimateclassicrock.com%2Fmegadeth-dystopia-album%2F&docid=LebK_2-ytDo9kM&tbnid=s4H_o6BbYDqNQM%3A&vet=10ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ..i&w=980&h=983&bih=578&biw=1280&q=megadeth%20album%20covers&ved=0ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ&iact=mrc&uact=8", "Sergio" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/JCole.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/ArianaGrande.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/Pink.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/Megadeth.jpg");
        }
    }
}
