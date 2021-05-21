﻿// <auto-generated />
using System;
using BP_Webshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BP_Webshop.Migrations
{
    [DbContext(typeof(BlackPDbContext))]
    partial class BlackPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BP_Webshop.Models.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("BP_Webshop.Models.Jewelry", b =>
                {
                    b.Property<int>("JewelryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageRating")
                        .HasColumnType("float");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JewelryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JewelryID");

                    b.ToTable("Jewelries");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Jewelry");
                });

            modelBuilder.Entity("BP_Webshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DeliveryPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BP_Webshop.Models.OrderLine", b =>
                {
                    b.Property<int>("OrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JewelryId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.HasKey("OrderLineId");

                    b.HasIndex("JewelryId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("BP_Webshop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BP_Webshop.Models.Bracelet", b =>
                {
                    b.HasBaseType("BP_Webshop.Models.Jewelry");

                    b.Property<double>("BraceletLength")
                        .HasColumnType("float");

                    b.Property<string>("BraceletType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BraceletWidth")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Bracelet");
                });

            modelBuilder.Entity("BP_Webshop.Models.Earring", b =>
                {
                    b.HasBaseType("BP_Webshop.Models.Jewelry");

                    b.Property<double>("EarringLength")
                        .HasColumnType("float");

                    b.Property<int>("EarringType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Earring");
                });

            modelBuilder.Entity("BP_Webshop.Models.HeadJewelry", b =>
                {
                    b.HasBaseType("BP_Webshop.Models.Jewelry");

                    b.Property<int>("HeadJewType")
                        .HasColumnType("int");

                    b.Property<string>("HeadJewelrySize")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("HeadJewelry");
                });

            modelBuilder.Entity("BP_Webshop.Models.Necklace", b =>
                {
                    b.HasBaseType("BP_Webshop.Models.Jewelry");

                    b.Property<double>("NecklaceLength")
                        .HasColumnType("float");

                    b.Property<int>("NecklaceType")
                        .HasColumnType("int");

                    b.Property<double>("NecklaceWidth")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Necklace");
                });

            modelBuilder.Entity("BP_Webshop.Models.Ring", b =>
                {
                    b.HasBaseType("BP_Webshop.Models.Jewelry");

                    b.Property<int>("RingSize")
                        .HasColumnType("int");

                    b.Property<int>("RingType")
                        .HasColumnType("int");

                    b.Property<double>("RingWidth")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Ring");
                });

            modelBuilder.Entity("BP_Webshop.Models.Order", b =>
                {
                    b.HasOne("BP_Webshop.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BP_Webshop.Models.OrderLine", b =>
                {
                    b.HasOne("BP_Webshop.Models.Jewelry", "Jewelry")
                        .WithMany()
                        .HasForeignKey("JewelryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BP_Webshop.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jewelry");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BP_Webshop.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
