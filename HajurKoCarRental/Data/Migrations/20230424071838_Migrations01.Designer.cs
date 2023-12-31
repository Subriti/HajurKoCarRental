﻿// <auto-generated />
using System;
using HajurKoCarRental.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HajurKoCarRental.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230424071838_Migrations01")]
    partial class Migrations01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HajurKoCarRental.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.CarRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("approvedBy")
                        .HasColumnType("integer");

                    b.Property<int>("carId")
                        .HasColumnType("integer");

                    b.Property<int>("customerId")
                        .HasColumnType("integer");

                    b.Property<int>("duration")
                        .HasColumnType("integer");

                    b.Property<bool>("isDamaged")
                        .HasColumnType("boolean");

                    b.Property<bool>("isPaid")
                        .HasColumnType("boolean");

                    b.Property<float>("rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("requestedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("returnedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<int>("totalAmount")
                        .HasColumnType("integer");

                    b.Property<int>("totalDiscount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("approvedBy");

                    b.HasIndex("carId");

                    b.HasIndex("customerId");

                    b.ToTable("CarRequests");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.Property<int>("RequestId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.HasIndex("RequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.RepairBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("amount")
                        .HasColumnType("integer");

                    b.Property<bool>("isPaid")
                        .HasColumnType("boolean");

                    b.Property<int>("issuedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("paidAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("requestId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("issuedBy");

                    b.HasIndex("requestId");

                    b.ToTable("RepairBill");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.CarRequest", b =>
                {
                    b.HasOne("HajurKoCarRental.Models.User", "ApprovalUser")
                        .WithMany("CarRequestsApproval")
                        .HasForeignKey("approvedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HajurKoCarRental.Models.Car", "Car")
                        .WithMany("CarRequests")
                        .HasForeignKey("carId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HajurKoCarRental.Models.User", "CustomerUser")
                        .WithMany("CarRequestsCustomer")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApprovalUser");

                    b.Navigation("Car");

                    b.Navigation("CustomerUser");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Notification", b =>
                {
                    b.HasOne("HajurKoCarRental.Models.Offer", "Offer")
                        .WithMany("Notifications")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HajurKoCarRental.Models.CarRequest", "CarRequest")
                        .WithMany("Notifications")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HajurKoCarRental.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("CarRequest");

                    b.Navigation("Offer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Offer", b =>
                {
                    b.HasOne("HajurKoCarRental.Models.Car", "Car")
                        .WithMany("Offers")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.RepairBill", b =>
                {
                    b.HasOne("HajurKoCarRental.Models.User", "User")
                        .WithMany("RepairBillRequests")
                        .HasForeignKey("issuedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HajurKoCarRental.Models.CarRequest", "CarRequest")
                        .WithMany("RepairBill")
                        .HasForeignKey("requestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarRequest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.UserRole", b =>
                {
                    b.HasOne("HajurKoCarRental.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Car", b =>
                {
                    b.Navigation("CarRequests");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.CarRequest", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("RepairBill");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.Offer", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("HajurKoCarRental.Models.User", b =>
                {
                    b.Navigation("CarRequestsApproval");

                    b.Navigation("CarRequestsCustomer");

                    b.Navigation("RepairBillRequests");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
