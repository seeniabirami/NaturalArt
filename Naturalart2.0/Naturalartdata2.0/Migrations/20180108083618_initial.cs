using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Naturalartdata2._0.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotItemCost",
                table: "Orderdetail",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Orderdetail_OrderID",
                table: "Orderdetail",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderdetail_Order_OrderID",
                table: "Orderdetail",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderdetail_Order_OrderID",
                table: "Orderdetail");

            migrationBuilder.DropIndex(
                name: "IX_Orderdetail_OrderID",
                table: "Orderdetail");

            migrationBuilder.DropColumn(
                name: "TotItemCost",
                table: "Orderdetail");
        }
    }
}
