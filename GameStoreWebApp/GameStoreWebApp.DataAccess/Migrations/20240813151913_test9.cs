using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderGame_Games_ProductId",
                table: "OrderGame");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGame_Order_OrderId",
                table: "OrderGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGame",
                table: "OrderGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("52c0c7e3-ed73-421d-9315-ee323dd5be97"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7bc5dbc1-2de6-45e1-b572-47fb8336d3ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7e64857c-e039-4a97-81b7-a00b35b28a98"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9f605e56-e679-434d-bc02-7e1fc81a8fca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4e2a54d-d7ac-40d4-977f-43eb128a5fe5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a5d79b5c-accf-42b3-8adb-2c38bc736b98"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a6241a1e-dee9-4d37-8f9c-e509fbaedeb1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("baaea8e8-2210-4a89-b9a6-5c60f3de25d0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d88d6348-f211-40c8-8af6-94d7b16370a9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ea33fb1c-c25d-4926-a361-e93205ed6c2f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ef19aa7d-1b92-487f-a703-cdc4c171e9b2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f9f51049-d666-412c-8e5c-afb622630b80"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("1f2adc82-ddff-4a05-991d-75441dfda9ff"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("6f804f9b-1190-48b4-84be-8cdeedb57558"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("7680e349-5f86-4b28-b02d-ba53ea1979bc"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("e9978035-ff8c-4aa0-bd98-76b25eb17b69"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4fdc6d3-43b4-4cef-ba94-b8517dc98ebf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ada5841e-2a78-46b4-a2ed-788f2f5bb301"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453"));

            migrationBuilder.RenameTable(
                name: "OrderGame",
                newName: "OrderGames");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGame_ProductId",
                table: "OrderGames",
                newName: "IX_OrderGames_ProductId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGames_Games_ProductId",
                table: "OrderGames",
                column: "ProductId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGames_Orders_OrderId",
                table: "OrderGames",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderGames_Games_ProductId",
                table: "OrderGames");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderGames_Orders_OrderId",
                table: "OrderGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames");

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

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderGames",
                newName: "OrderGame");

            migrationBuilder.RenameIndex(
                name: "IX_OrderGames_ProductId",
                table: "OrderGame",
                newName: "IX_OrderGame_ProductId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Order",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGame",
                table: "OrderGame",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("52c0c7e3-ed73-421d-9315-ee323dd5be97"), "Adventure", null },
                    { new Guid("a4e2a54d-d7ac-40d4-977f-43eb128a5fe5"), "RPG", null },
                    { new Guid("a4fdc6d3-43b4-4cef-ba94-b8517dc98ebf"), "Strategy", null },
                    { new Guid("a5d79b5c-accf-42b3-8adb-2c38bc736b98"), "Sports", null },
                    { new Guid("ada5841e-2a78-46b4-a2ed-788f2f5bb301"), "Action", null },
                    { new Guid("baaea8e8-2210-4a89-b9a6-5c60f3de25d0"), "Puzzle & Skill", null },
                    { new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453"), "Races", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1f2adc82-ddff-4a05-991d-75441dfda9ff"), "Browser" },
                    { new Guid("6f804f9b-1190-48b4-84be-8cdeedb57558"), "Mobile" },
                    { new Guid("7680e349-5f86-4b28-b02d-ba53ea1979bc"), "Console" },
                    { new Guid("e9978035-ff8c-4aa0-bd98-76b25eb17b69"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("7bc5dbc1-2de6-45e1-b572-47fb8336d3ed"), "FPS", new Guid("ada5841e-2a78-46b4-a2ed-788f2f5bb301") },
                    { new Guid("7e64857c-e039-4a97-81b7-a00b35b28a98"), "RTS", new Guid("a4fdc6d3-43b4-4cef-ba94-b8517dc98ebf") },
                    { new Guid("9f605e56-e679-434d-bc02-7e1fc81a8fca"), "Formula", new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453") },
                    { new Guid("a6241a1e-dee9-4d37-8f9c-e509fbaedeb1"), "TBS", new Guid("a4fdc6d3-43b4-4cef-ba94-b8517dc98ebf") },
                    { new Guid("d88d6348-f211-40c8-8af6-94d7b16370a9"), "Arcade", new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453") },
                    { new Guid("ea33fb1c-c25d-4926-a361-e93205ed6c2f"), "TPS", new Guid("ada5841e-2a78-46b4-a2ed-788f2f5bb301") },
                    { new Guid("ef19aa7d-1b92-487f-a703-cdc4c171e9b2"), "Rally", new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453") },
                    { new Guid("f9f51049-d666-412c-8e5c-afb622630b80"), "Off-road", new Guid("ed7c7a49-a74e-441e-9104-7c2a8b534453") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGame_Games_ProductId",
                table: "OrderGame",
                column: "ProductId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderGame_Order_OrderId",
                table: "OrderGame",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
