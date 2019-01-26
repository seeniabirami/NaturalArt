using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Naturalartdata2._0.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Addid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Add1 = table.Column<string>(nullable: true),
                    Add2 = table.Column<string>(nullable: true),
                    Addtype = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    UserType = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    postcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Addid);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    UserRoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    ContactNo = table.Column<int>(nullable: false),
                    Customername = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Whatsapp = table.Column<bool>(nullable: false),
                    WhatsappNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "Addid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Addid = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: false),
                    ContactNo = table.Column<int>(nullable: false),
                    EmailID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    UserroleID = table.Column<int>(nullable: false),
                    Whatsapp = table.Column<bool>(nullable: false),
                    WhatsappNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistID);
                    table.ForeignKey(
                        name: "FK_Artist_Address_Addid",
                        column: x => x.Addid,
                        principalTable: "Address",
                        principalColumn: "Addid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artist_UserRole_UserroleID",
                        column: x => x.UserroleID,
                        principalTable: "UserRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderStatusID = table.Column<int>(nullable: false),
                    OrderStatusName = table.Column<string>(nullable: true),
                    Requireddate = table.Column<DateTime>(nullable: false),
                    SameShippingAdd = table.Column<bool>(nullable: false),
                    Statusid = table.Column<int>(nullable: true),
                    ToAddressAddid = table.Column<int>(nullable: true),
                    TotalCost = table.Column<float>(nullable: false),
                    TotalItem = table.Column<int>(nullable: false),
                    shipAdd1 = table.Column<string>(nullable: true),
                    shipAdd2 = table.Column<string>(nullable: true),
                    shipCity = table.Column<string>(nullable: true),
                    shipState = table.Column<string>(nullable: true),
                    shipcountry = table.Column<string>(nullable: true),
                    shippedDate = table.Column<DateTime>(nullable: false),
                    shippostcode = table.Column<short>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Address_ToAddressAddid",
                        column: x => x.ToAddressAddid,
                        principalTable: "Address",
                        principalColumn: "Addid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtItem",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtistID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ItemTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Measure = table.Column<string>(maxLength: 5, nullable: false),
                    Prize = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    YearMade = table.Column<int>(maxLength: 4, nullable: false),
                    availability = table.Column<string>(maxLength: 20, nullable: true),
                    imageurl = table.Column<string>(nullable: true),
                    postedDate = table.Column<DateTime>(nullable: false),
                    statusid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtItem", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_ArtItem_Artist_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artist",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCatagory",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtItemItemID = table.Column<int>(nullable: true),
                    CategoryType = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCatagory", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_ItemCatagory_ArtItem_ArtItemItemID",
                        column: x => x.ArtItemItemID,
                        principalTable: "ArtItem",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orderdetail",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    ItemRunNo = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Unitprize = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderdetail", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_Orderdetail_ArtItem_ItemID",
                        column: x => x.ItemID,
                        principalTable: "ArtItem",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Statusid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtItemItemID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatusName = table.Column<string>(nullable: false),
                    StatusType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Statusid);
                    table.ForeignKey(
                        name: "FK_Status_ArtItem_ArtItemItemID",
                        column: x => x.ArtItemItemID,
                        principalTable: "ArtItem",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enquiry",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CusContactNo = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(nullable: false),
                    FeedStatus = table.Column<int>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Statusid = table.Column<int>(nullable: false),
                    createddate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquiry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enquiry_Status_Statusid",
                        column: x => x.Statusid,
                        principalTable: "Status",
                        principalColumn: "Statusid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Addid",
                table: "Artist",
                column: "Addid");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_UserroleID",
                table: "Artist",
                column: "UserroleID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtItem_ArtistID",
                table: "ArtItem",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtItem_CategoryID",
                table: "ArtItem",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtItem_statusid",
                table: "ArtItem",
                column: "statusid");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressID",
                table: "Customer",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Enquiry_Statusid",
                table: "Enquiry",
                column: "Statusid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCatagory_ArtItemItemID",
                table: "ItemCatagory",
                column: "ArtItemItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Statusid",
                table: "Order",
                column: "Statusid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ToAddressAddid",
                table: "Order",
                column: "ToAddressAddid");

            migrationBuilder.CreateIndex(
                name: "IX_Orderdetail_ItemID",
                table: "Orderdetail",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Status_ArtItemItemID",
                table: "Status",
                column: "ArtItemItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Status_Statusid",
                table: "Order",
                column: "Statusid",
                principalTable: "Status",
                principalColumn: "Statusid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtItem_ItemCatagory_CategoryID",
                table: "ArtItem",
                column: "CategoryID",
                principalTable: "ItemCatagory",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtItem_Status_statusid",
                table: "ArtItem",
                column: "statusid",
                principalTable: "Status",
                principalColumn: "Statusid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Address_Addid",
                table: "Artist");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_UserRole_UserroleID",
                table: "Artist");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtItem_Artist_ArtistID",
                table: "ArtItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtItem_ItemCatagory_CategoryID",
                table: "ArtItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtItem_Status_statusid",
                table: "ArtItem");

            migrationBuilder.DropTable(
                name: "Enquiry");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Orderdetail");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "ItemCatagory");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "ArtItem");
        }
    }
}
