﻿// <auto-generated />
using System;
using AppDiplomVasilenkoTepaykim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppDiplomVasilenkoTepaykim.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220416113850_adddb")]
    partial class adddb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("NameCategory")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyLocationId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<int>("RequisitesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyLocationId");

                    b.HasIndex("RequisitesId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.LocationCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LocationCompanys");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.LocationDelivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LocationDeliverys");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LocationDeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationDeliveryId");

                    b.HasIndex("StaffId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.OrderDetails", b =>
                {
                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UnitId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.RequisitesClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<decimal>("KPP")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("LegalInn")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("longtext");

                    b.Property<decimal>("PhysicalInn")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("RequisitesClient");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.RequisitesCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<decimal>("KPP")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("LegalInn")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("longtext");

                    b.Property<decimal>("PhysicalInn")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("RequisitesCompanys");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyLocationId")
                        .HasColumnType("int");

                    b.Property<string>("NameSuppliers")
                        .HasColumnType("longtext");

                    b.Property<string>("OwnerCompany")
                        .HasColumnType("longtext");

                    b.Property<int>("RequisitesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyLocationId");

                    b.HasIndex("RequisitesId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Customer", b =>
                {
                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.LocationDelivery", "LocationDelivery")
                        .WithMany()
                        .HasForeignKey("CompanyLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.RequisitesClient", "RequisitesClient")
                        .WithMany()
                        .HasForeignKey("RequisitesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationDelivery");

                    b.Navigation("RequisitesClient");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Order", b =>
                {
                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.LocationDelivery", "LocationDelivery")
                        .WithMany()
                        .HasForeignKey("LocationDeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("LocationDelivery");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.OrderDetails", b =>
                {
                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Product", b =>
                {
                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("AppDiplomVasilenkoTepaykim.Models.Supplier", b =>
                {
                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.LocationCompany", "LocationCompanys")
                        .WithMany()
                        .HasForeignKey("CompanyLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDiplomVasilenkoTepaykim.Models.RequisitesCompany", "RequisitesCompany")
                        .WithMany()
                        .HasForeignKey("RequisitesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationCompanys");

                    b.Navigation("RequisitesCompany");
                });
#pragma warning restore 612, 618
        }
    }
}
