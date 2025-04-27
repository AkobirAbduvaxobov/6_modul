using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("027bba02-5468-4ed3-b082-12b6d8b4de61"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("196e69ad-459f-439f-9b32-e7e7c60683b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2a2e9f07-2fb6-40e9-b708-f5aaa20df0c3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2be416b2-fd54-43db-a24d-9bfb829ffe42"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("54d5e711-a13f-4e5d-a3a2-ac34491a9fe9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6d7bf281-b141-4c39-95d9-1c43f607ba6c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7306bffe-62be-4d89-80eb-c15d266023cc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7aa6cd20-e2ce-41a2-949b-8f6625ce0177"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8e6473ce-9008-48da-838a-35417c94f8ea"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94f804b0-aec5-4546-be53-2d8a3bd74b2b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dc5bb11c-370e-46ac-be09-30c1eaaad78f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e5d07714-1fa9-451e-8cd7-4f647f457479"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("5fc42436-d9fa-4457-92ae-4ee5694f7d46"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("7c54b04f-7fb4-4ffb-b08f-f23620c1b393"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("7dd628fb-48fa-4806-a3be-74341f3ab1c6"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("9f89098d-f089-4735-8b84-c218a76fab33"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c"));

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "OrderGames",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("1e2a05ff-8e37-4e7a-a332-52ab79a208dd"), "Strategy", null },
                    { new Guid("4ff509e4-9403-4b6e-98e0-ab66de2e9424"), "Adventure", null },
                    { new Guid("51698e17-0533-47a8-b4cc-2a6b7e1052b4"), "Action", null },
                    { new Guid("660f9f64-0049-41a6-918d-277ed174a1ba"), "Races", null },
                    { new Guid("71ef9928-eb05-42c1-a47a-7d04a2c79183"), "Puzzle & Skill", null },
                    { new Guid("8c3079df-c4fa-4b81-84ad-a01b10ba49c3"), "Sports", null },
                    { new Guid("a9d97087-5f47-49b3-9a24-6f61bc1a50ff"), "RPG", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("3627a97a-511b-4170-a787-3abe9e9d6b3d"), "Cool way3", "Link3", "Visa" },
                    { new Guid("ca3b4a01-fbb8-44f3-bc48-a272986f7f16"), "Cool way1", "Link1", "Bank" },
                    { new Guid("f33b77cd-717d-4636-ad74-9308f9466a4b"), "Cool way2", "Link2", "IBox terminal" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("25b3ccf9-1666-447f-97b1-bded62d66392"), "Desktop" },
                    { new Guid("262822af-83c2-4a65-86b5-771a7f5bbd77"), "Browser" },
                    { new Guid("a8d48a1e-21f9-480d-ba9a-f7771662dce5"), "Mobile" },
                    { new Guid("f2188a6b-2457-42c7-8034-0c1679d10387"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("040c32d0-6da6-4351-a695-31620980b798"), "Formula", new Guid("660f9f64-0049-41a6-918d-277ed174a1ba") },
                    { new Guid("15be0cc4-d4a7-4e55-901b-a78809387a67"), "Off-road", new Guid("660f9f64-0049-41a6-918d-277ed174a1ba") },
                    { new Guid("29ff547c-45ea-4702-a183-fdec33d12de3"), "FPS", new Guid("51698e17-0533-47a8-b4cc-2a6b7e1052b4") },
                    { new Guid("315a361d-23e3-4494-b0c1-03d6ab4f70a7"), "Arcade", new Guid("660f9f64-0049-41a6-918d-277ed174a1ba") },
                    { new Guid("cb448b38-b046-462f-bf63-62e33b88cf17"), "TBS", new Guid("1e2a05ff-8e37-4e7a-a332-52ab79a208dd") },
                    { new Guid("e3281204-39a3-40e1-b12e-bbf370da9486"), "RTS", new Guid("1e2a05ff-8e37-4e7a-a332-52ab79a208dd") },
                    { new Guid("f7816783-a56f-4d00-8482-4e5e23efc7bf"), "TPS", new Guid("51698e17-0533-47a8-b4cc-2a6b7e1052b4") },
                    { new Guid("ff1556bc-4141-4165-a7c6-32ac252cc89d"), "Rally", new Guid("660f9f64-0049-41a6-918d-277ed174a1ba") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("040c32d0-6da6-4351-a695-31620980b798"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("15be0cc4-d4a7-4e55-901b-a78809387a67"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("29ff547c-45ea-4702-a183-fdec33d12de3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("315a361d-23e3-4494-b0c1-03d6ab4f70a7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4ff509e4-9403-4b6e-98e0-ab66de2e9424"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("71ef9928-eb05-42c1-a47a-7d04a2c79183"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8c3079df-c4fa-4b81-84ad-a01b10ba49c3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a9d97087-5f47-49b3-9a24-6f61bc1a50ff"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cb448b38-b046-462f-bf63-62e33b88cf17"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e3281204-39a3-40e1-b12e-bbf370da9486"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f7816783-a56f-4d00-8482-4e5e23efc7bf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ff1556bc-4141-4165-a7c6-32ac252cc89d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("25b3ccf9-1666-447f-97b1-bded62d66392"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("262822af-83c2-4a65-86b5-771a7f5bbd77"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a8d48a1e-21f9-480d-ba9a-f7771662dce5"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("f2188a6b-2457-42c7-8034-0c1679d10387"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1e2a05ff-8e37-4e7a-a332-52ab79a208dd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("51698e17-0533-47a8-b4cc-2a6b7e1052b4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("660f9f64-0049-41a6-918d-277ed174a1ba"));

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "OrderGames",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("027bba02-5468-4ed3-b082-12b6d8b4de61"), "Sports", null },
                    { new Guid("2a2e9f07-2fb6-40e9-b708-f5aaa20df0c3"), "Adventure", null },
                    { new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806"), "Action", null },
                    { new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19"), "Strategy", null },
                    { new Guid("7aa6cd20-e2ce-41a2-949b-8f6625ce0177"), "Puzzle & Skill", null },
                    { new Guid("94f804b0-aec5-4546-be53-2d8a3bd74b2b"), "RPG", null },
                    { new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c"), "Races", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("5fc42436-d9fa-4457-92ae-4ee5694f7d46"), "Browser" },
                    { new Guid("7c54b04f-7fb4-4ffb-b08f-f23620c1b393"), "Desktop" },
                    { new Guid("7dd628fb-48fa-4806-a3be-74341f3ab1c6"), "Console" },
                    { new Guid("9f89098d-f089-4735-8b84-c218a76fab33"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("196e69ad-459f-439f-9b32-e7e7c60683b0"), "Rally", new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c") },
                    { new Guid("2be416b2-fd54-43db-a24d-9bfb829ffe42"), "Off-road", new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c") },
                    { new Guid("54d5e711-a13f-4e5d-a3a2-ac34491a9fe9"), "Formula", new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c") },
                    { new Guid("6d7bf281-b141-4c39-95d9-1c43f607ba6c"), "TBS", new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19") },
                    { new Guid("7306bffe-62be-4d89-80eb-c15d266023cc"), "TPS", new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806") },
                    { new Guid("8e6473ce-9008-48da-838a-35417c94f8ea"), "FPS", new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806") },
                    { new Guid("dc5bb11c-370e-46ac-be09-30c1eaaad78f"), "Arcade", new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c") },
                    { new Guid("e5d07714-1fa9-451e-8cd7-4f647f457479"), "RTS", new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19") }
                });
        }
    }
}
