using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherId",
                table: "Games",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "UnitInStock",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HomePage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("194874ea-d110-40f5-9cfa-b23168f92dbd"), "Strategy", null },
                    { new Guid("35e5c411-a55e-4f94-ab3f-da4c7ab7cb86"), "Puzzle & Skill", null },
                    { new Guid("70d7a04a-0390-4b60-8a95-7397b93e52f6"), "Sports", null },
                    { new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3"), "Races", null },
                    { new Guid("d3428dcf-e9c2-4b9c-857b-fdba3e89cfd2"), "RPG", null },
                    { new Guid("f28c3bb1-5025-40f9-b34b-97a488079b15"), "Adventure", null },
                    { new Guid("f9128ee9-9c14-403d-8bf8-786b200d07d4"), "Action", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("354b96c0-5d9f-4dd0-810e-7b77ae13f11d"), "Browser" },
                    { new Guid("557b5f02-b749-4406-ac7d-d93b67b10027"), "Console" },
                    { new Guid("a390f4da-9aec-47a1-a22c-b562759180f4"), "Desktop" },
                    { new Guid("b8535026-d525-4d35-a357-026bda0a9d7f"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("028b2ccc-b090-419a-9a6d-d7dc7a42386b"), "Formula", new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3") },
                    { new Guid("55d14cd0-0715-42f4-bd31-1f966c895977"), "Rally", new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3") },
                    { new Guid("7ca3250d-3cb6-474a-bc06-c4907de47ec5"), "TPS", new Guid("f9128ee9-9c14-403d-8bf8-786b200d07d4") },
                    { new Guid("a206650c-050c-4c05-9cea-b532d6fd9711"), "Off-road", new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3") },
                    { new Guid("addd020d-eb08-4444-a428-df258f87401b"), "RTS", new Guid("194874ea-d110-40f5-9cfa-b23168f92dbd") },
                    { new Guid("b98396b5-5b85-4a12-adf4-39f1a1c76c53"), "TBS", new Guid("194874ea-d110-40f5-9cfa-b23168f92dbd") },
                    { new Guid("d49849e0-e1a4-42d2-b3b0-873e0e57fc05"), "Arcade", new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3") },
                    { new Guid("f7ca90df-31a6-48b9-8b98-19240910be6d"), "FPS", new Guid("f9128ee9-9c14-403d-8bf8-786b200d07d4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_CompanyName",
                table: "Publisher",
                column: "CompanyName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publisher_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publisher_PublisherId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Games_PublisherId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("028b2ccc-b090-419a-9a6d-d7dc7a42386b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("35e5c411-a55e-4f94-ab3f-da4c7ab7cb86"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("55d14cd0-0715-42f4-bd31-1f966c895977"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("70d7a04a-0390-4b60-8a95-7397b93e52f6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7ca3250d-3cb6-474a-bc06-c4907de47ec5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a206650c-050c-4c05-9cea-b532d6fd9711"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("addd020d-eb08-4444-a428-df258f87401b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b98396b5-5b85-4a12-adf4-39f1a1c76c53"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d3428dcf-e9c2-4b9c-857b-fdba3e89cfd2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d49849e0-e1a4-42d2-b3b0-873e0e57fc05"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f28c3bb1-5025-40f9-b34b-97a488079b15"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f7ca90df-31a6-48b9-8b98-19240910be6d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("354b96c0-5d9f-4dd0-810e-7b77ae13f11d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("557b5f02-b749-4406-ac7d-d93b67b10027"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a390f4da-9aec-47a1-a22c-b562759180f4"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("b8535026-d525-4d35-a357-026bda0a9d7f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("194874ea-d110-40f5-9cfa-b23168f92dbd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8771821-c9f3-4583-b5f2-7d6292b141e3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f9128ee9-9c14-403d-8bf8-786b200d07d4"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "UnitInStock",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
