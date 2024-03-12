using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NormalCrude.Migrations
{
    public partial class AddDataInMembarship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Masala dosa')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Chole bhature')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Aloo gobi')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Vada')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Tandoori chicken')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Samosa')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Rogan josh')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Palak paneer')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Biryani')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Butter chicken')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Dal')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Dosa')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Idli')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Naan')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Chaat')");
            migrationBuilder.Sql("INSERT INTO [Membarships] VALUES ('Tea')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Membarships");
        }
    }
}
