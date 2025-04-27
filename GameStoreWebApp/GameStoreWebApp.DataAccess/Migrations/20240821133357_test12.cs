using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("24100014-1340-447a-ab8b-23299c346d05"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("280b09d7-ab75-4e95-aaa8-bef7793a662d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4092ec42-fce4-4f7a-945b-e3e39def26f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6240345c-d251-43b4-9907-ce320966dd5c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6a939fdb-9aab-43a2-b76c-d520f6a86f55"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7045a1c9-7342-4837-867c-2cdf07fb2e67"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("897d7e9b-3ab6-4aa4-a81f-7cdd4ca6bf2e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b671f49b-0f53-47cf-a969-4578bce7ed23"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b7614617-40b0-41a1-a55d-e521dd606fb0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d26b099a-cf1a-4b9c-9ff6-71a8ad37ac28"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d49af098-40ee-4752-a39d-fb70d2bea027"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f45379dc-407f-4c4e-960a-10c9433a6539"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("dcbe76be-4ea2-4ca0-b4cf-78e2b6f3c99d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("fa1fa045-6002-45ce-86e2-4dc6a7e6cf00"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("ff5a096a-350e-4867-89c4-e558f493b96f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("7b4a1fbe-5315-464a-9767-806b72a24cc8"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("80b7312e-0eb5-46d8-9d62-04cae861e454"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("8fdbf226-58e6-42fa-9a2e-3f72542271e2"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("909e6a32-8e4e-4d3a-bb6e-c12d494e3d9b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("65ba7d87-ac61-4aab-923d-38a18ceab800"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("97932e8d-ca8a-4631-a97b-071f87b372a3"));

            migrationBuilder.CreateTable(
                name: "BanDurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanDurations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BanDurations",
                columns: new[] { "Id", "Duration" },
                values: new object[,]
                {
                    { new Guid("31bac2e0-2ccd-42a3-852b-542061a9789a"), "1 day" },
                    { new Guid("5ca65b46-6e37-401a-95c6-ffd141d427e1"), "1 month" },
                    { new Guid("958c9d98-2a9a-40a7-9792-b61b24084a6b"), "1 hour" },
                    { new Guid("960d0067-16b6-417d-91ef-2e746835a30c"), "1 week" },
                    { new Guid("cc141eea-f0e9-40cb-9eca-7fa05c0dd458"), "permanent" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("2904aa60-8616-48f7-8711-8af2597c62c5"), "Races", null },
                    { new Guid("a949b8b0-0411-4863-821f-3356a99f07b9"), "Strategy", null },
                    { new Guid("c0443750-7f7f-4ee7-9c7f-c37380381168"), "Action", null },
                    { new Guid("c996541a-7841-4aa2-851b-0b0e19bab8ec"), "Puzzle & Skill", null },
                    { new Guid("dbce3aaf-6466-4a7e-8969-9ab75e70a5e8"), "Adventure", null },
                    { new Guid("f258407b-2a40-4a2a-a5bd-1e2135ad5514"), "RPG", null },
                    { new Guid("ff8aea40-b546-4f5d-a662-95971f95f736"), "Sports", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("258648d4-29ec-4cc4-8f7c-462fed0f7102"), "Cool way2", "Link2", "IBox terminal" },
                    { new Guid("77e49b1d-fa31-4dc7-b0af-946e26e431f4"), "Cool way3", "Link3", "Visa" },
                    { new Guid("ef8af8bb-210b-491a-b98f-008357615332"), "Cool way1", "Link1", "Bank" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("47944f83-26ca-474f-92a6-16dfeb08de94"), "Mobile" },
                    { new Guid("6c890d87-9901-4290-a48e-c8018e5e1df6"), "Desktop" },
                    { new Guid("acda2a01-7a5b-411a-a555-f85e4ae0b885"), "Console" },
                    { new Guid("d3771f97-5340-4392-aa3b-c483830137cd"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("40ed9962-570d-4c60-b2bc-ed1d9f0f4026"), "Off-road", new Guid("2904aa60-8616-48f7-8711-8af2597c62c5") },
                    { new Guid("4c7b938d-90f7-404c-a16b-b6d7751d2568"), "Rally", new Guid("2904aa60-8616-48f7-8711-8af2597c62c5") },
                    { new Guid("5bb474b9-8ef6-4da6-813a-7222c7a99136"), "FPS", new Guid("c0443750-7f7f-4ee7-9c7f-c37380381168") },
                    { new Guid("6e3b22bf-445e-41df-83b5-7bfe7b2e2281"), "Arcade", new Guid("2904aa60-8616-48f7-8711-8af2597c62c5") },
                    { new Guid("724f1e29-5a82-4944-b942-fca4e15ddf0d"), "Formula", new Guid("2904aa60-8616-48f7-8711-8af2597c62c5") },
                    { new Guid("a169a2a5-de53-406a-ad9f-266e8a1662c0"), "TBS", new Guid("a949b8b0-0411-4863-821f-3356a99f07b9") },
                    { new Guid("b6496a8c-0daa-499c-994a-707c14c98864"), "TPS", new Guid("c0443750-7f7f-4ee7-9c7f-c37380381168") },
                    { new Guid("d7d0d278-b9b6-41b9-a24b-0ef164eebf24"), "RTS", new Guid("a949b8b0-0411-4863-821f-3356a99f07b9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanDurations");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("40ed9962-570d-4c60-b2bc-ed1d9f0f4026"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c7b938d-90f7-404c-a16b-b6d7751d2568"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5bb474b9-8ef6-4da6-813a-7222c7a99136"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6e3b22bf-445e-41df-83b5-7bfe7b2e2281"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("724f1e29-5a82-4944-b942-fca4e15ddf0d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a169a2a5-de53-406a-ad9f-266e8a1662c0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6496a8c-0daa-499c-994a-707c14c98864"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c996541a-7841-4aa2-851b-0b0e19bab8ec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d7d0d278-b9b6-41b9-a24b-0ef164eebf24"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dbce3aaf-6466-4a7e-8969-9ab75e70a5e8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f258407b-2a40-4a2a-a5bd-1e2135ad5514"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ff8aea40-b546-4f5d-a662-95971f95f736"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("258648d4-29ec-4cc4-8f7c-462fed0f7102"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("77e49b1d-fa31-4dc7-b0af-946e26e431f4"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("ef8af8bb-210b-491a-b98f-008357615332"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("47944f83-26ca-474f-92a6-16dfeb08de94"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("6c890d87-9901-4290-a48e-c8018e5e1df6"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("acda2a01-7a5b-411a-a555-f85e4ae0b885"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d3771f97-5340-4392-aa3b-c483830137cd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2904aa60-8616-48f7-8711-8af2597c62c5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a949b8b0-0411-4863-821f-3356a99f07b9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c0443750-7f7f-4ee7-9c7f-c37380381168"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("4092ec42-fce4-4f7a-945b-e3e39def26f2"), "Adventure", null },
                    { new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65"), "Races", null },
                    { new Guid("65ba7d87-ac61-4aab-923d-38a18ceab800"), "Action", null },
                    { new Guid("6a939fdb-9aab-43a2-b76c-d520f6a86f55"), "Puzzle & Skill", null },
                    { new Guid("897d7e9b-3ab6-4aa4-a81f-7cdd4ca6bf2e"), "RPG", null },
                    { new Guid("97932e8d-ca8a-4631-a97b-071f87b372a3"), "Strategy", null },
                    { new Guid("d26b099a-cf1a-4b9c-9ff6-71a8ad37ac28"), "Sports", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("dcbe76be-4ea2-4ca0-b4cf-78e2b6f3c99d"), "Cool way3", "Link3", "Visa" },
                    { new Guid("fa1fa045-6002-45ce-86e2-4dc6a7e6cf00"), "Cool way1", "Link1", "Bank" },
                    { new Guid("ff5a096a-350e-4867-89c4-e558f493b96f"), "Cool way2", "Link2", "IBox terminal" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("7b4a1fbe-5315-464a-9767-806b72a24cc8"), "Browser" },
                    { new Guid("80b7312e-0eb5-46d8-9d62-04cae861e454"), "Mobile" },
                    { new Guid("8fdbf226-58e6-42fa-9a2e-3f72542271e2"), "Console" },
                    { new Guid("909e6a32-8e4e-4d3a-bb6e-c12d494e3d9b"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("24100014-1340-447a-ab8b-23299c346d05"), "Arcade", new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65") },
                    { new Guid("280b09d7-ab75-4e95-aaa8-bef7793a662d"), "TPS", new Guid("65ba7d87-ac61-4aab-923d-38a18ceab800") },
                    { new Guid("6240345c-d251-43b4-9907-ce320966dd5c"), "FPS", new Guid("65ba7d87-ac61-4aab-923d-38a18ceab800") },
                    { new Guid("7045a1c9-7342-4837-867c-2cdf07fb2e67"), "Rally", new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65") },
                    { new Guid("b671f49b-0f53-47cf-a969-4578bce7ed23"), "TBS", new Guid("97932e8d-ca8a-4631-a97b-071f87b372a3") },
                    { new Guid("b7614617-40b0-41a1-a55d-e521dd606fb0"), "Off-road", new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65") },
                    { new Guid("d49af098-40ee-4752-a39d-fb70d2bea027"), "Formula", new Guid("4dbc5b5b-ed3d-47e1-b0e5-d148f3478f65") },
                    { new Guid("f45379dc-407f-4c4e-960a-10c9433a6539"), "RTS", new Guid("97932e8d-ca8a-4631-a97b-071f87b372a3") }
                });
        }
    }
}
