using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("08e541db-5309-4fa0-9eba-a0acaf490401"), "Races", null },
                    { new Guid("0cf6686c-dc8b-4ebf-abbd-72f848988f21"), "Adventure", null },
                    { new Guid("3a6306a8-009e-4de6-9024-bd2930ba8d0d"), "RPG", null },
                    { new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca"), "Action", null },
                    { new Guid("59dc7cbe-24dc-49c0-b006-73522746bcee"), "Sports", null },
                    { new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea"), "Strategy", null },
                    { new Guid("f26aab11-aa3a-40f4-8348-d24f795a0b66"), "Puzzle & Skill", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("23a151aa-c310-4541-8546-a7e2157b0881"), "Mobile" },
                    { new Guid("26f4ea19-33a3-4250-8ce2-d1343ad56535"), "Browser" },
                    { new Guid("2fd39690-2a6a-490c-89d2-60e49bf9a59a"), "Console" },
                    { new Guid("4cf08d4f-14a9-4bfe-a0c0-e9c76890bae9"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("07e92e87-b945-46a2-bbf3-1dac254e8ce5"), "Rally", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("6488d748-6091-4eee-9cf4-fefd3c86b3a4"), "TBS", new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea") },
                    { new Guid("7d8bdf9e-3723-4139-84a0-442260cc8b98"), "TPS", new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca") },
                    { new Guid("84bec329-6b48-4eb9-a79a-9e7bdc0f1269"), "FPS", new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca") },
                    { new Guid("a4404352-ec01-4037-bd1b-b536100e5107"), "Off-road", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("b068099f-9260-422c-860e-32f0ed136daf"), "Formula", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("b925b01b-4d60-4516-9e3e-34c65f6b6b11"), "RTS", new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea") },
                    { new Guid("d328a361-eb0e-4abf-8837-4ad36382ec0c"), "Arcade", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("07e92e87-b945-46a2-bbf3-1dac254e8ce5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0cf6686c-dc8b-4ebf-abbd-72f848988f21"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3a6306a8-009e-4de6-9024-bd2930ba8d0d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("59dc7cbe-24dc-49c0-b006-73522746bcee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6488d748-6091-4eee-9cf4-fefd3c86b3a4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d8bdf9e-3723-4139-84a0-442260cc8b98"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("84bec329-6b48-4eb9-a79a-9e7bdc0f1269"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4404352-ec01-4037-bd1b-b536100e5107"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b068099f-9260-422c-860e-32f0ed136daf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b925b01b-4d60-4516-9e3e-34c65f6b6b11"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d328a361-eb0e-4abf-8837-4ad36382ec0c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f26aab11-aa3a-40f4-8348-d24f795a0b66"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("23a151aa-c310-4541-8546-a7e2157b0881"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("26f4ea19-33a3-4250-8ce2-d1343ad56535"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("2fd39690-2a6a-490c-89d2-60e49bf9a59a"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("4cf08d4f-14a9-4bfe-a0c0-e9c76890bae9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("08e541db-5309-4fa0-9eba-a0acaf490401"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea"));

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
        }
    }
}
