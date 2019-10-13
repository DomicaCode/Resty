using Microsoft.EntityFrameworkCore.Migrations;

namespace Resty.Web.Migrations
{
    public partial class _111 : Migration
    {
        #region Methods

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Test",
                table: "FoodItem",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "FoodItem");
        }

        #endregion Methods
    }
}