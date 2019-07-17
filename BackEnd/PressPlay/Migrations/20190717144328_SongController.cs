using Microsoft.EntityFrameworkCore.Migrations;

namespace PressPlay.Migrations
{
    public partial class SongController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4,
                columns: new[] { "Link", "SongTitle" },
                values: new object[] { "https://www.youtube.com/watch?v=Lcm9qqo_qB0", "Tornado of Souls" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4,
                columns: new[] { "Link", "SongTitle" },
                values: new object[] { "https://www.youtube.com/watch?v=bK95lWHl7js", "Dystopia" });
        }
    }
}
