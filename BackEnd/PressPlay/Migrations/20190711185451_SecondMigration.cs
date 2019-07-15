using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Artists");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "J Cole", "/images/JCole.jpg/" },
                    { 2, "Ariana Grande", "/images/ArianaGrande.jpg/" },
                    { 3, "Pink", "/images/Pink.jpg/" },
                    { 4, "Megadeth", "/images/Megadeth.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Artists",
                nullable: false,
                defaultValue: 0);
        }
    }
}
