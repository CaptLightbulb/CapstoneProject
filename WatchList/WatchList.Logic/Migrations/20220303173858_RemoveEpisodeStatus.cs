using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchList.Logic.Migrations
{
    public partial class RemoveEpisodeStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "StatusNum",
                table: "Episodes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusNum",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
