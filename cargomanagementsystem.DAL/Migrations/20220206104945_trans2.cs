using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class trans2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    Bill_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender_id = table.Column<int>(type: "int", nullable: false),
                    Type_of_goods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goods_Qty = table.Column<int>(type: "int", nullable: false),
                    Trans_amount = table.Column<int>(type: "int", nullable: false),
                    Sending_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Receiver_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.Bill_no);
                    table.ForeignKey(
                        name: "FK_transaction_customer_details_Sender_id",
                        column: x => x.Sender_id,
                        principalTable: "customer_details",
                        principalColumn: "custId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_Sender_id",
                table: "transaction",
                column: "Sender_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaction");
        }
    }
}
