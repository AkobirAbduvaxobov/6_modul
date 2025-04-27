using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations;

/// <inheritdoc />
public partial class test8 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("1f405bf3-e010-4bfa-97e9-b22eaeacb6e9"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("242b2edd-e33c-4f14-9501-add2655be788"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("61f09102-2034-4bd6-88a5-9148514501bf"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("761115df-c259-49f6-a26c-3f14db50551b"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("7ab5c1b0-e046-4b02-b644-f11e9b9bbc1b"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("920288f2-e552-49b8-a8fd-4adf0df5a781"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("a2a4169c-ab32-40db-8f9b-d1f12087f7cf"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("cd6efd02-1b48-4f95-a822-baccf010b8cc"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("cdd77b04-9f1e-494c-8a87-54d47370e26a"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("d1d3fea5-21e7-45c0-bd09-c35130165855"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("da1c1dde-e8ed-4700-a729-28688dd6ba5f"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("fa7b6de9-d1a6-4143-9049-895c1beb9308"));

        migrationBuilder.DeleteData(
            table: "Platforms",
            keyColumn: "Id",
            keyValue: new Guid("54c479d2-c530-429d-b3a8-4e46719a53bd"));

        migrationBuilder.DeleteData(
            table: "Platforms",
            keyColumn: "Id",
            keyValue: new Guid("bf5e657f-30a4-4af1-b5f6-dbe31af77164"));

        migrationBuilder.DeleteData(
            table: "Platforms",
            keyColumn: "Id",
            keyValue: new Guid("c5765317-9f8b-44fd-a402-3a1ccf6d9cb2"));

        migrationBuilder.DeleteData(
            table: "Platforms",
            keyColumn: "Id",
            keyValue: new Guid("f39b4e5d-5c44-4ca6-b47f-918e6e034cd8"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("e7f21d69-58ae-4c0e-826b-146c2dddffbc"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e"));

        migrationBuilder.DeleteData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: new Guid("f34e7a9d-68cb-41c2-9eda-853c5362554a"));

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
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
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

        migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name", "ParentGenreId" },
            values: new object[,]
            {
                { new Guid("1f405bf3-e010-4bfa-97e9-b22eaeacb6e9"), "Sports", null },
                { new Guid("242b2edd-e33c-4f14-9501-add2655be788"), "Adventure", null },
                { new Guid("7ab5c1b0-e046-4b02-b644-f11e9b9bbc1b"), "RPG", null },
                { new Guid("da1c1dde-e8ed-4700-a729-28688dd6ba5f"), "Puzzle & Skill", null },
                { new Guid("e7f21d69-58ae-4c0e-826b-146c2dddffbc"), "Strategy", null },
                { new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e"), "Races", null },
                { new Guid("f34e7a9d-68cb-41c2-9eda-853c5362554a"), "Action", null }
            });

        migrationBuilder.InsertData(
            table: "Platforms",
            columns: new[] { "Id", "Type" },
            values: new object[,]
            {
                { new Guid("54c479d2-c530-429d-b3a8-4e46719a53bd"), "Browser" },
                { new Guid("bf5e657f-30a4-4af1-b5f6-dbe31af77164"), "Desktop" },
                { new Guid("c5765317-9f8b-44fd-a402-3a1ccf6d9cb2"), "Console" },
                { new Guid("f39b4e5d-5c44-4ca6-b47f-918e6e034cd8"), "Mobile" }
            });

        migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name", "ParentGenreId" },
            values: new object[,]
            {
                { new Guid("61f09102-2034-4bd6-88a5-9148514501bf"), "TPS", new Guid("f34e7a9d-68cb-41c2-9eda-853c5362554a") },
                { new Guid("761115df-c259-49f6-a26c-3f14db50551b"), "TBS", new Guid("e7f21d69-58ae-4c0e-826b-146c2dddffbc") },
                { new Guid("920288f2-e552-49b8-a8fd-4adf0df5a781"), "Formula", new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e") },
                { new Guid("a2a4169c-ab32-40db-8f9b-d1f12087f7cf"), "Off-road", new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e") },
                { new Guid("cd6efd02-1b48-4f95-a822-baccf010b8cc"), "FPS", new Guid("f34e7a9d-68cb-41c2-9eda-853c5362554a") },
                { new Guid("cdd77b04-9f1e-494c-8a87-54d47370e26a"), "Arcade", new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e") },
                { new Guid("d1d3fea5-21e7-45c0-bd09-c35130165855"), "Rally", new Guid("eb910ea7-9198-4dc6-8d30-934adf4d273e") },
                { new Guid("fa7b6de9-d1a6-4143-9049-895c1beb9308"), "RTS", new Guid("e7f21d69-58ae-4c0e-826b-146c2dddffbc") }
            });
    }
}
