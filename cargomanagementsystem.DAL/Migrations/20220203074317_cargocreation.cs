using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class cargocreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    CustEmailid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Custname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobile = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.CustEmailid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
