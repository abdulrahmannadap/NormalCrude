using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NormalCrude.Migrations
{
    public partial class NewAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "baseModels");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "baseModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_baseModels_CustomerId",
                table: "baseModels",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_baseModels_Customers_CustomerId",
                table: "baseModels",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_baseModels_Customers_CustomerId",
                table: "baseModels");

            migrationBuilder.DropIndex(
                name: "IX_baseModels_CustomerId",
                table: "baseModels");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "baseModels");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "baseModels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
