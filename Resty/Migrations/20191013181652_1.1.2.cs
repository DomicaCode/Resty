using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resty.Web.Migrations
{
    public partial class _112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FoodItemCategoryId",
                table: "FoodItem",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_FoodItem_FoodItemCategoryId",
                table: "FoodItem",
                column: "FoodItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItem_FoodItemCategory_FoodItemCategoryId",
                table: "FoodItem",
                column: "FoodItemCategoryId",
                principalTable: "FoodItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItem_FoodItemCategory_FoodItemCategoryId",
                table: "FoodItem");

            migrationBuilder.DropIndex(
                name: "IX_FoodItem_FoodItemCategoryId",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "FoodItemCategoryId",
                table: "FoodItem");
        }
    }
}
