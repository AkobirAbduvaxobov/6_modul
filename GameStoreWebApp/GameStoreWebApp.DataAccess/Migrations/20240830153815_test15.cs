using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("0d911c1c-69d2-47bd-964f-1895414353f7"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("2087dea6-d2c5-4e34-ad02-7f2738fe14e7"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("5d185ed1-a416-421e-bebe-b291559294c3"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("692c9d90-8b90-4ee6-a1d9-dfd31ac7c459"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("a12d23cd-c1de-471e-9025-1d403dfabdd8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("04db6af3-ddde-4aac-8b6e-6efa23b6c30d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("06367a69-86e8-48c9-8675-7c3d4bf16640"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("17bd406a-9d91-4247-b31a-526f38ca43e2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("61f2ed1e-3098-40c1-a8eb-616bd5507c12"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94ea49c5-9e00-4264-90dc-bfffbe0c5d52"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ad5b05b-e670-4fc9-9e52-4f391f78235a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a28c2aaf-c2ff-4664-be21-e5a3f379d48e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bc067760-34d8-454a-a2b2-353fcf0d7ef2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e3421f39-083a-46a1-a160-c46d2206a9d1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9f2d202-fd17-409a-adb7-2f27b34b1f80"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("edd3de05-e9e2-411f-9be5-84e5226beb74"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f416e840-1d4c-464e-9046-6430a0b757e4"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("1785f2ad-55be-41e1-8442-88c21c5c7e57"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("24d3f39e-4f0c-4218-9118-62a0e579f327"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("2b2312f5-8a0f-4bc4-b90d-078bffa6baaf"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("976fc3eb-749f-4a8b-ba90-a58bb19251cb"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("cfbfce13-8728-4b06-870c-f9d299be7706"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("0aa6ae90-184b-4691-894a-6f2d359023cc"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("4741f705-5abe-4c8e-96bd-2ee5fb1c2a32"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("571bbde6-fcef-439f-9e17-b1cd87bf367c"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("19b303cc-46fb-4daa-aa97-6f418e3484c5"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("3ebd777c-af71-4568-acbf-069b39bb4234"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a0a0bdce-7e4f-4993-b89e-d31e02bf3b7e"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d4d251e1-0910-4cbf-9271-19795293e5fa"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("2ec573c2-f086-4d0f-9d73-3ec29a6bd9e6"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("7895132a-11ab-4a74-8cd9-fc1e15a58c72"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("c23d475e-b140-471d-9f31-c4d94f53fb66"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("d826377c-f7e6-4e6d-ae0b-a2518452b640"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9ce6302-9968-4f5a-923a-3319ed12448a"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("1bdecdf6-7074-4855-80c0-208f53313da9"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("44fafb8f-4390-41c7-9012-e3dd3c0706df"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("a22b6a87-df39-4eb0-9aff-020186a02be5"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("cf46e534-cc08-4bc8-9dc5-e4b60ca74526"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("e11c2aab-86a7-47c0-a56d-51215af36f65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fb43a10-f694-47a8-abaf-ae0ca2239d78"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c9b2b8b0-ecba-4109-9033-c03fbe9a2624"));

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "BanDurations",
                columns: new[] { "Id", "Duration" },
                values: new object[,]
                {
                    { new Guid("0ea8a8ad-5f2b-414a-8e55-a52f5d8e0c43"), "1 month" },
                    { new Guid("ae965c21-fd05-4a25-883c-8062d9afe979"), "permanent" },
                    { new Guid("b57b0bc6-4875-4b3c-aa04-caa2e89af4d3"), "1 week" },
                    { new Guid("be9516ac-ff56-4876-9b8c-daee1a3b490f"), "1 day" },
                    { new Guid("c52c874b-38d2-4596-854a-b898aa35987d"), "1 hour" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("00566141-7011-40af-82f0-87007ee80308"), "Strategy", null },
                    { new Guid("2cd26fd1-3b71-47c6-98f6-f869f3612828"), "RPG", null },
                    { new Guid("3e9fa5da-64d3-4a7d-95d6-d388ca71c7ad"), "Adventure", null },
                    { new Guid("bcbe3e8b-1723-4a8e-8965-8193d4917a62"), "Puzzle & Skill", null },
                    { new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8"), "Races", null },
                    { new Guid("f488d7fc-ad94-472c-8120-f09958e31db7"), "Sports", null },
                    { new Guid("f54a9a34-6a52-447b-b505-c055d33886e8"), "Action", null }
                });

            migrationBuilder.InsertData(
                table: "PaginationOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("5c0c2aff-8d6b-4b4e-9a12-167396ee49fb"), "10" },
                    { new Guid("62c9439d-91a3-47aa-b228-b4e2055992c2"), "50" },
                    { new Guid("73ecf7e4-3fc3-4ca6-b872-b5c3d37b0755"), "all" },
                    { new Guid("84337bc4-3d2f-4438-8559-d8f99716a284"), "100" },
                    { new Guid("9f6d317c-67de-4d5e-830b-fa280f261d15"), "20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("1f572aa2-3ca4-41e7-9666-4eb8ec7d6dab"), "Cool way2", "Link2", "IBox terminal" },
                    { new Guid("82c28574-792a-40b0-8edb-ac55d0df2fcd"), "Cool way3", "Link3", "Visa" },
                    { new Guid("9ce43b42-4525-48da-a98b-18623a9b7401"), "Cool way1", "Link1", "Bank" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("318e9eed-72e3-48df-91d4-dc6c270a2882"), "Desktop" },
                    { new Guid("c0f2a870-a487-4836-b0d4-51a3f93ed7bd"), "Browser" },
                    { new Guid("c77f716a-5cbd-43df-88e3-eaab1545a87d"), "Console" },
                    { new Guid("da88ada2-523e-489d-9d80-b1951f1e8d5e"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "PublishedDateFilterOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("123b81d8-b0e6-4f9f-8142-b39027b46adb"), "last week" },
                    { new Guid("13632cb6-1d77-4d25-895c-a7d3d5088c36"), "last month" },
                    { new Guid("24bc1c22-b226-4254-b358-8e3944afad2e"), "2 years" },
                    { new Guid("2ced9363-4f84-46d1-a487-0f9bb4206e51"), "3 years" },
                    { new Guid("50df5f2e-3f42-4c4a-a6f4-996dc844cf52"), "last year" }
                });

            migrationBuilder.InsertData(
                table: "SortingOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("146beb80-7d4f-4897-8360-26bd20be3045"), "Most commented" },
                    { new Guid("b870725e-e375-4acb-ab3f-0cbc3f3995ed"), "Price DESC" },
                    { new Guid("c4d469a0-7f00-499d-b9d5-420049304757"), "Price ASC" },
                    { new Guid("e4ccec3a-2418-4b15-9838-838e698bf253"), "New" },
                    { new Guid("fb081dc6-79e5-47a5-8751-e6a0ff1d2d06"), "Most popular" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0807c7eb-af44-4a02-b1e1-ecd61596e9bc"), "FPS", new Guid("f54a9a34-6a52-447b-b505-c055d33886e8") },
                    { new Guid("0fb6dc1a-754c-4351-ab93-7e42bc9b46d2"), "Rally", new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8") },
                    { new Guid("412e0545-c69d-40b3-8baf-807c8920af3d"), "TPS", new Guid("f54a9a34-6a52-447b-b505-c055d33886e8") },
                    { new Guid("4fb51243-4112-4970-9826-e838aa791b82"), "Off-road", new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8") },
                    { new Guid("7d33e4a3-ba6b-4586-95f8-86e98f414034"), "TBS", new Guid("00566141-7011-40af-82f0-87007ee80308") },
                    { new Guid("a4a7ee69-d8ca-4998-b938-43f474984af3"), "Arcade", new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8") },
                    { new Guid("e7c9d157-b25c-4ec6-acdc-3b3de0b1294e"), "RTS", new Guid("00566141-7011-40af-82f0-87007ee80308") },
                    { new Guid("f8715fd0-cc57-4054-8ec0-7b5c440ae6cb"), "Formula", new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("0ea8a8ad-5f2b-414a-8e55-a52f5d8e0c43"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("ae965c21-fd05-4a25-883c-8062d9afe979"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("b57b0bc6-4875-4b3c-aa04-caa2e89af4d3"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("be9516ac-ff56-4876-9b8c-daee1a3b490f"));

            migrationBuilder.DeleteData(
                table: "BanDurations",
                keyColumn: "Id",
                keyValue: new Guid("c52c874b-38d2-4596-854a-b898aa35987d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0807c7eb-af44-4a02-b1e1-ecd61596e9bc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0fb6dc1a-754c-4351-ab93-7e42bc9b46d2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2cd26fd1-3b71-47c6-98f6-f869f3612828"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3e9fa5da-64d3-4a7d-95d6-d388ca71c7ad"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("412e0545-c69d-40b3-8baf-807c8920af3d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4fb51243-4112-4970-9826-e838aa791b82"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d33e4a3-ba6b-4586-95f8-86e98f414034"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4a7ee69-d8ca-4998-b938-43f474984af3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bcbe3e8b-1723-4a8e-8965-8193d4917a62"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e7c9d157-b25c-4ec6-acdc-3b3de0b1294e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f488d7fc-ad94-472c-8120-f09958e31db7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f8715fd0-cc57-4054-8ec0-7b5c440ae6cb"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c0c2aff-8d6b-4b4e-9a12-167396ee49fb"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("62c9439d-91a3-47aa-b228-b4e2055992c2"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("73ecf7e4-3fc3-4ca6-b872-b5c3d37b0755"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("84337bc4-3d2f-4438-8559-d8f99716a284"));

            migrationBuilder.DeleteData(
                table: "PaginationOptions",
                keyColumn: "Id",
                keyValue: new Guid("9f6d317c-67de-4d5e-830b-fa280f261d15"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("1f572aa2-3ca4-41e7-9666-4eb8ec7d6dab"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("82c28574-792a-40b0-8edb-ac55d0df2fcd"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("9ce43b42-4525-48da-a98b-18623a9b7401"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("318e9eed-72e3-48df-91d4-dc6c270a2882"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("c0f2a870-a487-4836-b0d4-51a3f93ed7bd"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("c77f716a-5cbd-43df-88e3-eaab1545a87d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("da88ada2-523e-489d-9d80-b1951f1e8d5e"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("123b81d8-b0e6-4f9f-8142-b39027b46adb"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("13632cb6-1d77-4d25-895c-a7d3d5088c36"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("24bc1c22-b226-4254-b358-8e3944afad2e"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("2ced9363-4f84-46d1-a487-0f9bb4206e51"));

            migrationBuilder.DeleteData(
                table: "PublishedDateFilterOptions",
                keyColumn: "Id",
                keyValue: new Guid("50df5f2e-3f42-4c4a-a6f4-996dc844cf52"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("146beb80-7d4f-4897-8360-26bd20be3045"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("b870725e-e375-4acb-ab3f-0cbc3f3995ed"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("c4d469a0-7f00-499d-b9d5-420049304757"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("e4ccec3a-2418-4b15-9838-838e698bf253"));

            migrationBuilder.DeleteData(
                table: "SortingOptions",
                keyColumn: "Id",
                keyValue: new Guid("fb081dc6-79e5-47a5-8751-e6a0ff1d2d06"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("00566141-7011-40af-82f0-87007ee80308"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d77a9795-cdd8-45d9-8623-e893dcc191d8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f54a9a34-6a52-447b-b505-c055d33886e8"));

            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "Games");

            migrationBuilder.InsertData(
                table: "BanDurations",
                columns: new[] { "Id", "Duration" },
                values: new object[,]
                {
                    { new Guid("0d911c1c-69d2-47bd-964f-1895414353f7"), "permanent" },
                    { new Guid("2087dea6-d2c5-4e34-ad02-7f2738fe14e7"), "1 day" },
                    { new Guid("5d185ed1-a416-421e-bebe-b291559294c3"), "1 hour" },
                    { new Guid("692c9d90-8b90-4ee6-a1d9-dfd31ac7c459"), "1 week" },
                    { new Guid("a12d23cd-c1de-471e-9025-1d403dfabdd8"), "1 month" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("3fb43a10-f694-47a8-abaf-ae0ca2239d78"), "Strategy", null },
                    { new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb"), "Races", null },
                    { new Guid("bc067760-34d8-454a-a2b2-353fcf0d7ef2"), "Adventure", null },
                    { new Guid("c9b2b8b0-ecba-4109-9033-c03fbe9a2624"), "Action", null },
                    { new Guid("e9f2d202-fd17-409a-adb7-2f27b34b1f80"), "Sports", null },
                    { new Guid("edd3de05-e9e2-411f-9be5-84e5226beb74"), "Puzzle & Skill", null },
                    { new Guid("f416e840-1d4c-464e-9046-6430a0b757e4"), "RPG", null }
                });

            migrationBuilder.InsertData(
                table: "PaginationOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("1785f2ad-55be-41e1-8442-88c21c5c7e57"), "all" },
                    { new Guid("24d3f39e-4f0c-4218-9118-62a0e579f327"), "10" },
                    { new Guid("2b2312f5-8a0f-4bc4-b90d-078bffa6baaf"), "50" },
                    { new Guid("976fc3eb-749f-4a8b-ba90-a58bb19251cb"), "100" },
                    { new Guid("cfbfce13-8728-4b06-870c-f9d299be7706"), "20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("0aa6ae90-184b-4691-894a-6f2d359023cc"), "Cool way1", "Link1", "Bank" },
                    { new Guid("4741f705-5abe-4c8e-96bd-2ee5fb1c2a32"), "Cool way3", "Link3", "Visa" },
                    { new Guid("571bbde6-fcef-439f-9e17-b1cd87bf367c"), "Cool way2", "Link2", "IBox terminal" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("19b303cc-46fb-4daa-aa97-6f418e3484c5"), "Mobile" },
                    { new Guid("3ebd777c-af71-4568-acbf-069b39bb4234"), "Console" },
                    { new Guid("a0a0bdce-7e4f-4993-b89e-d31e02bf3b7e"), "Browser" },
                    { new Guid("d4d251e1-0910-4cbf-9271-19795293e5fa"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "PublishedDateFilterOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("2ec573c2-f086-4d0f-9d73-3ec29a6bd9e6"), "2 years" },
                    { new Guid("7895132a-11ab-4a74-8cd9-fc1e15a58c72"), "last week" },
                    { new Guid("c23d475e-b140-471d-9f31-c4d94f53fb66"), "last year" },
                    { new Guid("d826377c-f7e6-4e6d-ae0b-a2518452b640"), "3 years" },
                    { new Guid("e9ce6302-9968-4f5a-923a-3319ed12448a"), "last month" }
                });

            migrationBuilder.InsertData(
                table: "SortingOptions",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { new Guid("1bdecdf6-7074-4855-80c0-208f53313da9"), "Most popular" },
                    { new Guid("44fafb8f-4390-41c7-9012-e3dd3c0706df"), "Most commented" },
                    { new Guid("a22b6a87-df39-4eb0-9aff-020186a02be5"), "New" },
                    { new Guid("cf46e534-cc08-4bc8-9dc5-e4b60ca74526"), "Price DESC" },
                    { new Guid("e11c2aab-86a7-47c0-a56d-51215af36f65"), "Price ASC" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("04db6af3-ddde-4aac-8b6e-6efa23b6c30d"), "TPS", new Guid("c9b2b8b0-ecba-4109-9033-c03fbe9a2624") },
                    { new Guid("06367a69-86e8-48c9-8675-7c3d4bf16640"), "RTS", new Guid("3fb43a10-f694-47a8-abaf-ae0ca2239d78") },
                    { new Guid("17bd406a-9d91-4247-b31a-526f38ca43e2"), "TBS", new Guid("3fb43a10-f694-47a8-abaf-ae0ca2239d78") },
                    { new Guid("61f2ed1e-3098-40c1-a8eb-616bd5507c12"), "Formula", new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb") },
                    { new Guid("94ea49c5-9e00-4264-90dc-bfffbe0c5d52"), "Off-road", new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb") },
                    { new Guid("9ad5b05b-e670-4fc9-9e52-4f391f78235a"), "FPS", new Guid("c9b2b8b0-ecba-4109-9033-c03fbe9a2624") },
                    { new Guid("a28c2aaf-c2ff-4664-be21-e5a3f379d48e"), "Arcade", new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb") },
                    { new Guid("e3421f39-083a-46a1-a160-c46d2206a9d1"), "Rally", new Guid("5c2dc20b-ba2d-4b0c-9256-cb9d0315e8fb") }
                });
        }
    }
}
