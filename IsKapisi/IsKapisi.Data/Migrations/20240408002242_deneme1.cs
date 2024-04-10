using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IsKapisi.Data.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9489), "Eğitim Kategorisi", new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9504), "Öğretmen", "ogretmen" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9510), "Hukuk", new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9510), "Avukat", "avukat" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9512), "Bilgi İşlem", new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9512), "Yazılım Geliştirme Uzmanı", "yazilim-geliştirme-uzmani" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9513), "İnsan Kaynaklari Uzmani", new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9514), "İnsan Kaynaklari Uzmanı", "insan-kaynaklari-uzmani" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9515), "Developer", new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9515), "Back-End Developer", "back-end-developer" });

            migrationBuilder.InsertData(
                table: "CategoryJob",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 4, 2 },
                    { 4, 9 },
                    { 5, 5 },
                    { 5, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(365), "Kimya Öğretmeni", "Deneyimli Öğretmen", "kimya-ogretmen" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(373), "İnsan Kaynakları Uzmanı", " En az 3 yıl tecrübeli", "insan-kaynaklari-uzmani" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(375), "Kıdemli Avukat", "Deneyimi 5 - 10 yıl arası", "avukat" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(377), "Yazılım Destek Elemanı", "Tecrübeli/Tecrübesiz", "yazilim-destek-uzmani" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(378), "Backend Developer (İstanbul-Ankara-İzmir)", "  En az 3 yıl deneyimli,", "back-end-gelistirici" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(380), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(380), "React Front-End Geliştirici", "2 - 6 yıl arası", "react-front-end" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(382), "React Native Developer", "En az 3 yıl deneyimli", "react-native" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(383), "Data Science Professionals - Discovery (İstanbul, Ankara, İzmir)", "Uzman", "data-science" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(385), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(385), "İdari İşler Profesyonelleri ", "Minimum 7 yıl idari işler alanında deneyimli", "idari-isler" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(387), "Front-end Developer ", "Minimum 7 yıl react üzerinde çalışmış", "idari-isler" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(389), "Müzük Öğretmeni", "En az 10 yıl tecrübeli", "muzik-ogretmen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryJob",
                keyColumns: new[] { "CategoryId", "JobId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5683), "TV kategorisi", new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5700), "Televizyon", "televizyon" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5706), "Bilgisayar kategorisi", new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5707), "Bilgisayar", "bilgisayar" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5708), "Elektronik Eşya kategorisi", new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5708), "Elektronik Eşya", "elektronik-esya" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5709), "Beyaz Eşya kategorisi", new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5710), "Beyaz Eşya", "beyaz-esya" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate", "Name", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5711), "Telefon kategorisi", new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(5711), "Telefon", "telefon" });

            migrationBuilder.InsertData(
                table: "CategoryJob",
                columns: new[] { "CategoryId", "JobId" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6610), "IPhone 14", "Harika bir telefon", "iphone-14" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6618), "IPhone 14 Pro", "Bu da harika bir telefon", "iphone-14-pro" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6620), "Samsung S23", "İdare eder", "samsung-s23" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6622), "Xaomi Note 4", "Harika bir telefon", "xaomi-note-4" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6624), "MacBook Air M2", "M2nin gücü", "macbook-air-m2" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6626), "MacBook Pro M3", "16 Gb ram", "macbook-pro-m3" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6628), "Vestel Çamaşır Makinesi X65", "Akıllı makine", "vestel-camasir-makinesi-x65" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6629), "Arçelik Çamaşır Makinesi A-4", "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6631), "Hoop Dijital Radyo X96", "Klasik radyo keyfi", "hoop-dijital-radyo-x96" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6633), "Xaomi Dijital Baskül", "Kilonuzu kontrol edin", "xaomi-dijital-baskul" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name", "Properties", "Url" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 4, 8, 3, 3, 22, 852, DateTimeKind.Local).AddTicks(6634), "Blaupunkt AC69 Led TV", "Android tv", "blaupunkt-ac69-led-tv" });
        }
    }
}
