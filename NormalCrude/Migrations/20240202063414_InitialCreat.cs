using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NormalCrude.Migrations
{
    public partial class InitialCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baseModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MembarshipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baseModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_baseModels_Membarships_MembarshipId",
                        column: x => x.MembarshipId,
                        principalTable: "Membarships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_baseModels_MembarshipId",
                table: "baseModels",
                column: "MembarshipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "baseModels");
        }
    }
}
