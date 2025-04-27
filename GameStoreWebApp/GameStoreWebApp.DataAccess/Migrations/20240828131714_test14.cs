using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "PaginationOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginationOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublishedDateFilterOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishedDateFilterOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SortingOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortingOptions", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaginationOptions");

            migrationBuilder.DropTable(
                name: "PublishedDateFilterOptions");

            migrationBuilder.DropTable(
                name: "SortingOptions");

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
    }
}
