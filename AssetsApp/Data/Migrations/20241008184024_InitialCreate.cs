using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAcquired = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InUse = table.Column<bool>(type: "INTEGER", nullable: false),
                    PurchasePrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "DateAcquired", "InUse", "Location", "Name", "PurchasePrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Office Chair", 120.5 },
                    { 2, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Laptop Dell XPS", 1500.0 },
                    { 3, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Projector", 650.0 },
                    { 4, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Standing Desk", 450.75 },
                    { 5, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Printer HP LaserJet", 299.99000000000001 },
                    { 6, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, "Desktop Monitor 24 inch", 220.0 },
                    { 7, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Smart TV", 800.0 },
                    { 8, new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Air Conditioner Unit", 1200.0 },
                    { 9, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Conference Table", 600.0 },
                    { 10, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, "Ergonomic Mouse", 45.0 },
                    { 11, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "MacBook Pro", 2400.0 },
                    { 12, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, "Whiteboard", 150.0 },
                    { 13, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, "Server Rack", 5000.0 },
                    { 14, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "Desktop PC", 1200.0 },
                    { 15, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, "3D Printer", 3500.0 },
                    { 16, new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Sound System", 900.0 },
                    { 17, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Digital Camera", 1200.0 },
                    { 18, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, "iPad Pro", 999.99000000000001 },
                    { 19, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Network Switch", 650.0 },
                    { 20, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Coffee Machine", 300.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
