using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("31bac2e0-2ccd-42a3-852b-542061a9789a"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("5ca65b46-6e37-401a-95c6-ffd141d427e1"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("958c9d98-2a9a-40a7-9792-b61b24084a6b"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("960d0067-16b6-417d-91ef-2e746835a30c"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("cc141eea-f0e9-40cb-9eca-7fa05c0dd458"));

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

            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BannedUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BanDurations",
                columns: new[] { "Id", "Duration" },
                values: new object[,]
                {
                    { new Guid("0d7a6320-5fa4-4c4e-a1a9-db76e15fe000"), "1 day" },
                    { new Guid("4e698dbf-7ce3-4366-82d9-06bb1e70269b"), "1 week" },
                    { new Guid("5ac36b91-9eba-45c9-a2a5-d5c4776ba720"), "1 month" },
                    { new Guid("a8916306-f606-4458-8e08-fa49f2950866"), "permanent" },
                    { new Guid("d1b4d9e0-1edd-46de-8b0d-92c6c0097ce8"), "1 hour" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("2451f6df-cae1-4ed8-967c-a34cb0c65955"), "Puzzle & Skill", null },
                    { new Guid("2945d873-065f-44b3-91d0-9495882ca934"), "Races", null },
                    { new Guid("40b768e9-c5e8-45f4-88dd-ae9c144856b5"), "Strategy", null },
                    { new Guid("4a803de1-096f-40c5-aaf2-6cf6706e8149"), "Adventure", null },
                    { new Guid("71948dfc-b5aa-4ad4-b055-c2efa4602490"), "Action", null },
                    { new Guid("8181e20b-2b88-4777-914e-1ba0202b5b47"), "Sports", null },
                    { new Guid("ec4fb215-2350-447b-8717-29c9bb68783c"), "RPG", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("2ac7a0d2-8d84-4545-a686-a4f669d5759e"), "Cool way1", "Link1", "Bank" },
                    { new Guid("5adf16a1-2f24-4387-badf-fdabbf63a080"), "Cool way2", "Link2", "IBox terminal" },
                    { new Guid("b05fd152-50fa-4e07-b658-b953342fd145"), "Cool way3", "Link3", "Visa" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2ebf0f2d-def5-4a12-b7a9-452dd72755d8"), "Mobile" },
                    { new Guid("63386839-b735-4d9a-85fa-f992720fbc41"), "Browser" },
                    { new Guid("846eb90b-ee6e-4929-8a84-7391a9ff40a1"), "Desktop" },
                    { new Guid("9fce1834-c98e-4a07-8554-fb0a1367f7f2"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0d523d3f-f4fe-4b2b-9602-70425dafb7ee"), "TPS", new Guid("71948dfc-b5aa-4ad4-b055-c2efa4602490") },
                    { new Guid("228fa0e4-fd1e-4bb4-92b1-088339b8b2db"), "Rally", new Guid("2945d873-065f-44b3-91d0-9495882ca934") },
                    { new Guid("334bafa5-7abc-47c7-bdd0-183589b9d960"), "Off-road", new Guid("2945d873-065f-44b3-91d0-9495882ca934") },
                    { new Guid("3fc509f6-7ff0-4b1d-84ac-2bc95b6e8e24"), "RTS", new Guid("40b768e9-c5e8-45f4-88dd-ae9c144856b5") },
                    { new Guid("925a9f8a-978c-4646-a6e5-eb7a7ebee96d"), "TBS", new Guid("40b768e9-c5e8-45f4-88dd-ae9c144856b5") },
                    { new Guid("9363daaa-40e3-4cb5-b314-6caf11f1c2e4"), "FPS", new Guid("71948dfc-b5aa-4ad4-b055-c2efa4602490") },
                    { new Guid("a6c7dd37-93c4-485c-b7b1-807f847030ab"), "Arcade", new Guid("2945d873-065f-44b3-91d0-9495882ca934") },
                    { new Guid("c2e1a182-7c39-4174-bca6-53a0da9af267"), "Formula", new Guid("2945d873-065f-44b3-91d0-9495882ca934") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bans");

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("0d7a6320-5fa4-4c4e-a1a9-db76e15fe000"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("4e698dbf-7ce3-4366-82d9-06bb1e70269b"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("5ac36b91-9eba-45c9-a2a5-d5c4776ba720"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("a8916306-f606-4458-8e08-fa49f2950866"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("d1b4d9e0-1edd-46de-8b0d-92c6c0097ce8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0d523d3f-f4fe-4b2b-9602-70425dafb7ee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("228fa0e4-fd1e-4bb4-92b1-088339b8b2db"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2451f6df-cae1-4ed8-967c-a34cb0c65955"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("334bafa5-7abc-47c7-bdd0-183589b9d960"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fc509f6-7ff0-4b1d-84ac-2bc95b6e8e24"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4a803de1-096f-40c5-aaf2-6cf6706e8149"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8181e20b-2b88-4777-914e-1ba0202b5b47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("925a9f8a-978c-4646-a6e5-eb7a7ebee96d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9363daaa-40e3-4cb5-b314-6caf11f1c2e4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a6c7dd37-93c4-485c-b7b1-807f847030ab"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c2e1a182-7c39-4174-bca6-53a0da9af267"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ec4fb215-2350-447b-8717-29c9bb68783c"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("2ac7a0d2-8d84-4545-a686-a4f669d5759e"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("5adf16a1-2f24-4387-badf-fdabbf63a080"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("b05fd152-50fa-4e07-b658-b953342fd145"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("2ebf0f2d-def5-4a12-b7a9-452dd72755d8"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("63386839-b735-4d9a-85fa-f992720fbc41"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("846eb90b-ee6e-4929-8a84-7391a9ff40a1"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("9fce1834-c98e-4a07-8554-fb0a1367f7f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2945d873-065f-44b3-91d0-9495882ca934"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("40b768e9-c5e8-45f4-88dd-ae9c144856b5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("71948dfc-b5aa-4ad4-b055-c2efa4602490"));

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
    }
}
