using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EfCoreTutorial2.Migrations
{
    public partial class AddedFKtoOrderCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Name", "Active", "DateCreated" },
                values: new object[,] {
                    { "P&G", true, DateTime.Now },
                    { "Amazon", true, DateTime.Now },
                    { "Walmart", true, DateTime.Now },
                    { "Target", true, DateTime.Now }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");
        }
    }
}
