using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchList.Logic.Migrations
{
    public partial class AddedStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusNum",
                table: "Shows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusNum",
                table: "Seasons",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "StatusNum",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "StatusNum",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "StatusNum",
                table: "Episodes");
        }
    }
}
