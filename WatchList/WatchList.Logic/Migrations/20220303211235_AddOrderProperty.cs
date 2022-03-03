using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchList.Logic.Migrations
{
    public partial class AddOrderProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Seasons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Episodes");
        }
    }
}
