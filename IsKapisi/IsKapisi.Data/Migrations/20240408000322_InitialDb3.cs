using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IsKapisi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDelete = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDelete = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryJob",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryJob", x => new { x.CategoryId, x.JobId });
                    table.ForeignKey(
                        name: "FK_CategoryJob_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryJob_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDelete", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5683), "TV kategorisi", true, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5700), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5706), "Bilgisayar kategorisi", true, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5707), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5708), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5708), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5709), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5710), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5711), "Telefon kategorisi", true, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5711), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDelete", "IsHome", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6607), null, "1.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6610), "IPhone 14", "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6618), null, "2.png", true, false, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6618), "IPhone 14 Pro", "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6620), null, "3.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6620), "Samsung S23", "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6622), null, "4.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6622), "Xaomi Note 4", "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6624), null, "5.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6624), "MacBook Air M2", "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6626), null, "6.png", true, false, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6626), "MacBook Pro M3", "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6627), null, "7.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6628), "Vestel Çamaşır Makinesi X65", "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6629), null, "8.png", true, false, false, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6629), "Arçelik Çamaşır Makinesi A-4", "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6631), null, "9.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6631), "Hoop Dijital Radyo X96", "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6632), null, "10.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6633), "Xaomi Dijital Baskül", "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6634), null, "11.png", true, false, true, new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6634), "Blaupunkt AC69 Led TV", "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "CategoryJob",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryJob_JobId",
                table: "CategoryJob",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryJob");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
