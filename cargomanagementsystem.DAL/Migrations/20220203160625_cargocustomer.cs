using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class cargocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer_details",
                columns: table => new
                {
                    custId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custPhone = table.Column<int>(type: "int", nullable: false),
                    custpincode = table.Column<int>(type: "int", nullable: false),
                    recNmae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recID = table.Column<int>(type: "int", nullable: false),
                    recAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rectId = table.Column<int>(type: "int", nullable: false),
                    rectCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recPhone = table.Column<int>(type: "int", nullable: false),
                    recpincode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_details", x => x.custId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_details");
        }
    }
}
