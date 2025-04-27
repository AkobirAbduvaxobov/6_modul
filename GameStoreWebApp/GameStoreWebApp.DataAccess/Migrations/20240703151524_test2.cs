using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("3d6a33a4-9799-4972-a82e-f4f55172bf9b"), "Adventure", null },
                    { new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0"), "Races", null },
                    { new Guid("6c9b1f19-24da-4653-8120-a01a083815a1"), "Strategy", null },
                    { new Guid("7855a4a4-c723-4321-b9d5-1962d87f1f30"), "Sports", null },
                    { new Guid("b3e759ac-a788-4258-a51d-9e43ac7fd685"), "Action", null },
                    { new Guid("cfe48cf3-c305-403a-af23-afd0a1b7f581"), "Puzzle & Skill", null },
                    { new Guid("f566807e-c22e-45cb-829c-a4619d8f373d"), "RPG", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1e400979-501b-462c-8409-f23c1375a7ed"), "Desktop" },
                    { new Guid("54f134be-dce5-4857-a305-92bef0a81b3e"), "Browser" },
                    { new Guid("cc4e8319-8610-482f-9ff1-36a0ae5ca13f"), "Mobile" },
                    { new Guid("d33c03a7-f9cf-4a1d-8808-174b56229687"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("220f8b1c-a807-4dec-90ed-f5d383a7b87a"), "Rally", new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0") },
                    { new Guid("59469bfa-fc08-4712-bcac-b6a38da35992"), "Formula", new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0") },
                    { new Guid("62c07bb9-82c5-432c-a838-7a4a2e080d38"), "TBS", new Guid("6c9b1f19-24da-4653-8120-a01a083815a1") },
                    { new Guid("65057d3c-0320-49cf-b621-368fecfb50bb"), "Arcade", new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0") },
                    { new Guid("65ee3277-b8b6-4145-8600-d98040dc6adb"), "FPS", new Guid("b3e759ac-a788-4258-a51d-9e43ac7fd685") },
                    { new Guid("9c6e6f56-bbe9-4717-92ff-28637e59a79d"), "TPS", new Guid("b3e759ac-a788-4258-a51d-9e43ac7fd685") },
                    { new Guid("b74d5676-a5e3-4a57-a8c6-a124912ad662"), "Off-road", new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0") },
                    { new Guid("f362ec09-a8bb-47d3-9e32-6607f9e8f54a"), "RTS", new Guid("6c9b1f19-24da-4653-8120-a01a083815a1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("220f8b1c-a807-4dec-90ed-f5d383a7b87a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3d6a33a4-9799-4972-a82e-f4f55172bf9b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("59469bfa-fc08-4712-bcac-b6a38da35992"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("62c07bb9-82c5-432c-a838-7a4a2e080d38"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("65057d3c-0320-49cf-b621-368fecfb50bb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("65ee3277-b8b6-4145-8600-d98040dc6adb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7855a4a4-c723-4321-b9d5-1962d87f1f30"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9c6e6f56-bbe9-4717-92ff-28637e59a79d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b74d5676-a5e3-4a57-a8c6-a124912ad662"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cfe48cf3-c305-403a-af23-afd0a1b7f581"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f362ec09-a8bb-47d3-9e32-6607f9e8f54a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f566807e-c22e-45cb-829c-a4619d8f373d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("1e400979-501b-462c-8409-f23c1375a7ed"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("54f134be-dce5-4857-a305-92bef0a81b3e"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("cc4e8319-8610-482f-9ff1-36a0ae5ca13f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d33c03a7-f9cf-4a1d-8808-174b56229687"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("472c69f5-31e4-4410-ab64-b44131ada9b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6c9b1f19-24da-4653-8120-a01a083815a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b3e759ac-a788-4258-a51d-9e43ac7fd685"));
        }
    }
}
