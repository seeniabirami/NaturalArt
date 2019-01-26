using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NaturalArtData;

namespace Naturalartdata2._0.Migrations
{
    [DbContext(typeof(NaturalArtdbContext))]
    partial class NaturalArtdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NaturalArtData.Models.Address", b =>
                {
                    b.Property<int>("Addid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Add1");

                    b.Property<string>("Add2");

                    b.Property<string>("Addtype");

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<int>("UserID");

                    b.Property<string>("UserType");

                    b.Property<string>("country");

                    b.Property<int>("postcode");

                    b.HasKey("Addid");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("NaturalArtData.Models.ArtistDetails", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Addid");

                    b.Property<string>("Area")
                        .IsRequired();

                    b.Property<int>("ContactNo");

                    b.Property<string>("EmailID")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<int>("UserroleID");

                    b.Property<bool>("Whatsapp");

                    b.Property<int>("WhatsappNo");

                    b.HasKey("ArtistID");

                    b.HasIndex("Addid");

                    b.HasIndex("UserroleID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("NaturalArtData.Models.ArtItem", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistID");

                    b.Property<int>("CategoryID");

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ItemTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Length");

                    b.Property<string>("Measure")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("Prize");

                    b.Property<int>("Width");

                    b.Property<int>("YearMade")
                        .HasMaxLength(4);

                    b.Property<string>("availability")
                        .HasMaxLength(20);

                    b.Property<string>("imageurl");

                    b.Property<DateTime>("postedDate");

                    b.Property<int>("statusid");

                    b.HasKey("ItemID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("statusid");

                    b.ToTable("ArtItem");
                });

            modelBuilder.Entity("NaturalArtData.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressID");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("ContactNo");

                    b.Property<string>("Customername")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<bool>("Whatsapp");

                    b.Property<int>("WhatsappNo");

                    b.HasKey("CustomerID");

                    b.HasIndex("AddressID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("NaturalArtData.Models.Enquiry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CusContactNo");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("FeedStatus")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Statusid");

                    b.Property<DateTime>("createddate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ID");

                    b.HasIndex("Statusid");

                    b.ToTable("Enquiry");
                });

            modelBuilder.Entity("NaturalArtData.Models.ItemCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtItemItemID");

                    b.Property<string>("CategoryType")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.HasKey("CategoryID");

                    b.HasIndex("ArtItemItemID");

                    b.ToTable("ItemCatagory");
                });

            modelBuilder.Entity("NaturalArtData.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderStatusID");

                    b.Property<string>("OrderStatusName");

                    b.Property<DateTime>("Requireddate");

                    b.Property<bool>("SameShippingAdd");

                    b.Property<int?>("Statusid");

                    b.Property<int?>("ToAddressAddid");

                    b.Property<float>("TotalCost");

                    b.Property<int>("TotalItem");

                    b.Property<string>("shipAdd1");

                    b.Property<string>("shipAdd2");

                    b.Property<string>("shipCity");

                    b.Property<string>("shipState");

                    b.Property<string>("shipcountry");

                    b.Property<DateTime>("shippedDate");

                    b.Property<short>("shippostcode")
                        .HasMaxLength(6);

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("Statusid");

                    b.HasIndex("ToAddressAddid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("NaturalArtData.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemID");

                    b.Property<int>("ItemRunNo");

                    b.Property<int>("OrderID");

                    b.Property<int>("Quantity");

                    b.Property<float>("TotItemCost");

                    b.Property<float>("Unitprize");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("ItemID");

                    b.HasIndex("OrderID");

                    b.ToTable("Orderdetail");
                });

            modelBuilder.Entity("NaturalArtData.Models.Status", b =>
                {
                    b.Property<int>("Statusid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtItemItemID");

                    b.Property<string>("Description");

                    b.Property<string>("StatusName")
                        .IsRequired();

                    b.Property<string>("StatusType")
                        .IsRequired();

                    b.HasKey("Statusid");

                    b.HasIndex("ArtItemItemID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("NaturalArtData.Models.UserRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("UserRoleName")
                        .IsRequired();

                    b.HasKey("RoleID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("NaturalArtData.Models.ArtistDetails", b =>
                {
                    b.HasOne("NaturalArtData.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("Addid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NaturalArtData.Models.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserroleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NaturalArtData.Models.ArtItem", b =>
                {
                    b.HasOne("NaturalArtData.Models.ArtistDetails", "ArtistDetail")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NaturalArtData.Models.ItemCategory", "Itemcategories")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NaturalArtData.Models.Status", "Statusrec")
                        .WithMany()
                        .HasForeignKey("statusid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NaturalArtData.Models.Customer", b =>
                {
                    b.HasOne("NaturalArtData.Models.Address", "FromAddress")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NaturalArtData.Models.Enquiry", b =>
                {
                    b.HasOne("NaturalArtData.Models.Status", "Statusrec")
                        .WithMany()
                        .HasForeignKey("Statusid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NaturalArtData.Models.ItemCategory", b =>
                {
                    b.HasOne("NaturalArtData.Models.ArtItem")
                        .WithMany("ItemcategoriesList")
                        .HasForeignKey("ArtItemItemID");
                });

            modelBuilder.Entity("NaturalArtData.Models.Order", b =>
                {
                    b.HasOne("NaturalArtData.Models.Customer", "Customer")
                        .WithMany("Orderslist")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NaturalArtData.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("Statusid");

                    b.HasOne("NaturalArtData.Models.Address", "ToAddress")
                        .WithMany()
                        .HasForeignKey("ToAddressAddid");
                });

            modelBuilder.Entity("NaturalArtData.Models.OrderDetails", b =>
                {
                    b.HasOne("NaturalArtData.Models.ArtItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NaturalArtData.Models.Order")
                        .WithMany("Cartlist")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NaturalArtData.Models.Status", b =>
                {
                    b.HasOne("NaturalArtData.Models.ArtItem")
                        .WithMany("StatusList")
                        .HasForeignKey("ArtItemItemID");
                });
        }
    }
}
