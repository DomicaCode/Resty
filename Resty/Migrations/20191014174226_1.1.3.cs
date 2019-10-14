using Microsoft.EntityFrameworkCore.Migrations;

namespace Resty.Web.Migrations
{
    public partial class _113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "FoodItem",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "FoodItem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "FoodItem");
        }
    }
}
