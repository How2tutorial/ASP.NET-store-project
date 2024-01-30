﻿// <auto-generated />
using System;
using ASP.NET_store_project.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ASP.NET_store_project.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240130153530_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.AdressDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdressDetails");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Category", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Type");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Customer", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserName");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.CustomerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Page")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.ItemConfiguration", b =>
                {
                    b.Property<int>("ConfigurationId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.HasKey("ConfigurationId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemConfiguration");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.OrderStatus", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("StatusCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfChange")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("OrderId", "StatusCode");

                    b.HasIndex("StatusCode");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.SelectedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("SelectedItem");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Status", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Image", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Item", null)
                        .WithMany("Gallery")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Item", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.ItemConfiguration", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Configuration", null)
                        .WithMany()
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Order", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.AdressDetails", "AdressDetails")
                        .WithOne()
                        .HasForeignKey("ASP.NET_store_project.Server.Data.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.CustomerDetails", "CustomerDetails")
                        .WithOne()
                        .HasForeignKey("ASP.NET_store_project.Server.Data.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdressDetails");

                    b.Navigation("Customer");

                    b.Navigation("CustomerDetails");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.OrderStatus", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Order", null)
                        .WithMany("StatusChangeHistory")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.Status", null)
                        .WithMany()
                        .HasForeignKey("StatusCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.SelectedItem", b =>
                {
                    b.HasOne("ASP.NET_store_project.Server.Data.Customer", "Customer")
                        .WithMany("Basket")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_store_project.Server.Data.Order", "Order")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderId");

                    b.Navigation("Customer");

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Customer", b =>
                {
                    b.Navigation("Basket");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Item", b =>
                {
                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("ASP.NET_store_project.Server.Data.Order", b =>
                {
                    b.Navigation("OrderedItems");

                    b.Navigation("StatusChangeHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
