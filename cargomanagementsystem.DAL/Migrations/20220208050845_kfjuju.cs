using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class kfjuju : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    AdminEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adminpassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.AdminEmail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
