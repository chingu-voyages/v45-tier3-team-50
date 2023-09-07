﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Data;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230907050910_First and Last Name")]
    partial class FirstandLastName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MealRequestsCompanions", b =>
                {
                    b.Property<string>("CompanionsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MealRequestModelId")
                        .HasColumnType("int");

                    b.HasKey("CompanionsId", "MealRequestModelId");

                    b.HasIndex("MealRequestModelId");

                    b.ToTable("MealRequestsCompanions");
                });

            modelBuilder.Entity("webapi.Models.MealRequestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MealRequests");
                });

            modelBuilder.Entity("webapi.Models.RestaurantModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Budget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main Street",
                            Budget = "$$$",
                            CreatorId = "1",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A cozy place with delicious food.",
                            Name = "Restaurant 1",
                            Style = "Italian"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm Avenue",
                            Budget = "$$",
                            CreatorId = "2",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Authentic flavors from around the world.",
                            Name = "Restaurant 2",
                            Style = "Asian Fusion"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak Street",
                            Budget = "$$$",
                            CreatorId = "3",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A modern atmosphere with a diverse menu.",
                            Name = "Restaurant 3",
                            Style = "American"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Maple Road",
                            Budget = "$$$$",
                            CreatorId = "4",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Experience fine dining at its best.",
                            Name = "Restaurant 4",
                            Style = "French"
                        },
                        new
                        {
                            Id = 5,
                            Address = "222 Pine Lane",
                            Budget = "$$",
                            CreatorId = "5",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Savor the taste of authentic sushi.",
                            Name = "Restaurant 5",
                            Style = "Japanese"
                        });
                });

            modelBuilder.Entity("webapi.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("BudgetMax")
                        .HasColumnType("int");

                    b.Property<int?>("BudgetMin")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ec9eaaf6-ac88-429e-a3c4-437ac8de36cc",
                            DateJoined = new DateTime(2023, 9, 7, 5, 9, 10, 568, DateTimeKind.Utc).AddTicks(7638),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user1@test.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@TEST.CA",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEGwpa15ss2K52hR0TwRqA7szNcMtuCmXUGq455KPRdfWL2ZAA33EIuRgkALs51DlmQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b104762-f73a-439f-82a6-2d33da0fb18f",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bb44616c-38dc-422a-92ee-6f1f194d49f2",
                            DateJoined = new DateTime(2023, 9, 7, 5, 9, 10, 621, DateTimeKind.Utc).AddTicks(4943),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user2@test.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@TEST.CA",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAEFEDzbK/tOBeu2rHSx0PqxJQPbjftjcnRPQtIgMLGU9Hh4eqmVI+IU2GWRZFxe07aA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec3a20c8-e38b-4969-bf2c-a0e63bf39fe0",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ec08051-c25b-4103-9ed8-6f0110035524",
                            DateJoined = new DateTime(2023, 9, 7, 5, 9, 10, 673, DateTimeKind.Utc).AddTicks(5065),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user3@test.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@TEST.CA",
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAIAAYagAAAAEBNbjYSG24i9gccoZ1AxRUoJtC/qDkIZxUMzkfEul5T1ZJJtwpDI8W9xAesotPhbaQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e00dc347-f4e5-4bf2-8cac-8e4376d643f7",
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "75ffdb9c-1704-4158-8529-bf75c672d1ef",
                            DateJoined = new DateTime(2023, 9, 7, 5, 9, 10, 728, DateTimeKind.Utc).AddTicks(2454),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user4@test.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER4@TEST.CA",
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAIAAYagAAAAEKfkIKcBGMAFOtUONklbghQ3aCJ9fHx6+ZZV6iiuWxUuJEO/Toj7iRzmthcIWa7OTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be624c88-406d-42ef-bc5c-8847afaf9658",
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb1bf862-5ed4-4289-a0fc-af94a700d02a",
                            DateJoined = new DateTime(2023, 9, 7, 5, 9, 10, 780, DateTimeKind.Utc).AddTicks(3288),
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user5@test.ca",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER5@TEST.CA",
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAIAAYagAAAAEIO+epgnmZAX1YoYN2r0m5qtUM3EnIhbAZCWjtlAqhwHIqkKjUE565HfcjRuUckuyg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d4e9f547-470b-4a95-81e4-b7ea7bd88e68",
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        });
                });

            modelBuilder.Entity("MealRequestsCompanions", b =>
                {
                    b.HasOne("webapi.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("CompanionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.MealRequestModel", null)
                        .WithMany()
                        .HasForeignKey("MealRequestModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Models.MealRequestModel", b =>
                {
                    b.HasOne("webapi.Models.UserModel", "Creator")
                        .WithMany("CreatedMealRequests")
                        .HasForeignKey("CreatorId");

                    b.HasOne("webapi.Models.RestaurantModel", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Creator");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("webapi.Models.RestaurantModel", b =>
                {
                    b.HasOne("webapi.Models.UserModel", "Creator")
                        .WithMany("CreatedRestaurants")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("webapi.Models.UserModel", b =>
                {
                    b.Navigation("CreatedMealRequests");

                    b.Navigation("CreatedRestaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
