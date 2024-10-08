﻿// <auto-generated />
using System;
using AssetsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetsApp.Data.Migrations
{
    [DbContext(typeof(AssetsDbContext))]
    partial class AssetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("AssetsApp.Data.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("TEXT");

                    b.Property<bool>("InUse")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Location")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAcquired = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 2,
                            Name = "Office Chair",
                            PurchasePrice = 120.5
                        },
                        new
                        {
                            Id = 2,
                            DateAcquired = new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 1,
                            Name = "Laptop Dell XPS",
                            PurchasePrice = 1500.0
                        },
                        new
                        {
                            Id = 3,
                            DateAcquired = new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = false,
                            Location = 3,
                            Name = "Projector",
                            PurchasePrice = 650.0
                        },
                        new
                        {
                            Id = 4,
                            DateAcquired = new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 2,
                            Name = "Standing Desk",
                            PurchasePrice = 450.75
                        },
                        new
                        {
                            Id = 5,
                            DateAcquired = new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 1,
                            Name = "Printer HP LaserJet",
                            PurchasePrice = 299.99000000000001
                        },
                        new
                        {
                            Id = 6,
                            DateAcquired = new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 0,
                            Name = "Desktop Monitor 24 inch",
                            PurchasePrice = 220.0
                        },
                        new
                        {
                            Id = 7,
                            DateAcquired = new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = false,
                            Location = 3,
                            Name = "Smart TV",
                            PurchasePrice = 800.0
                        },
                        new
                        {
                            Id = 8,
                            DateAcquired = new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 1,
                            Name = "Air Conditioner Unit",
                            PurchasePrice = 1200.0
                        },
                        new
                        {
                            Id = 9,
                            DateAcquired = new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 2,
                            Name = "Conference Table",
                            PurchasePrice = 600.0
                        },
                        new
                        {
                            Id = 10,
                            DateAcquired = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 0,
                            Name = "Ergonomic Mouse",
                            PurchasePrice = 45.0
                        },
                        new
                        {
                            Id = 11,
                            DateAcquired = new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 1,
                            Name = "MacBook Pro",
                            PurchasePrice = 2400.0
                        },
                        new
                        {
                            Id = 12,
                            DateAcquired = new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = false,
                            Location = 3,
                            Name = "Whiteboard",
                            PurchasePrice = 150.0
                        },
                        new
                        {
                            Id = 13,
                            DateAcquired = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 0,
                            Name = "Server Rack",
                            PurchasePrice = 5000.0
                        },
                        new
                        {
                            Id = 14,
                            DateAcquired = new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 2,
                            Name = "Desktop PC",
                            PurchasePrice = 1200.0
                        },
                        new
                        {
                            Id = 15,
                            DateAcquired = new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = false,
                            Location = 1,
                            Name = "3D Printer",
                            PurchasePrice = 3500.0
                        },
                        new
                        {
                            Id = 16,
                            DateAcquired = new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 3,
                            Name = "Sound System",
                            PurchasePrice = 900.0
                        },
                        new
                        {
                            Id = 17,
                            DateAcquired = new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = false,
                            Location = 0,
                            Name = "Digital Camera",
                            PurchasePrice = 1200.0
                        },
                        new
                        {
                            Id = 18,
                            DateAcquired = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 2,
                            Name = "iPad Pro",
                            PurchasePrice = 999.99000000000001
                        },
                        new
                        {
                            Id = 19,
                            DateAcquired = new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 3,
                            Name = "Network Switch",
                            PurchasePrice = 650.0
                        },
                        new
                        {
                            Id = 20,
                            DateAcquired = new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InUse = true,
                            Location = 1,
                            Name = "Coffee Machine",
                            PurchasePrice = 300.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
