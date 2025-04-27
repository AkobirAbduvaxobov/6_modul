using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1d0cafc4-b486-4127-a21f-c960e5ceafab"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2c301325-33cf-4258-9423-8f997e09833b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fcd7960-7640-4be3-8ed5-0617962d2adc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("62eeec67-2673-4698-b895-5d98f3ba707f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("827b7110-c634-47c1-901c-dcd4d28fbc15"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("89dbce53-1959-4e0f-a39e-5887b650acfb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("91517c08-72d8-4e25-830c-2845820fbda6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9534f46f-8ba5-43d4-b882-2c71855fe79a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ad8f495-03a6-461d-8738-0cdf766ebdee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cafcc239-5dc4-4a1c-9086-bde93ca6628f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d68d6dee-1f2a-4a1c-96bf-544a9cc0aca5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f13a6b40-5e13-4bd1-9d3a-7f2f875cb41e"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("40aa071c-e2d4-49bc-9a9f-9d7bb648eea5"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("44735e98-ddf4-428f-98e9-4bb6665c1ee8"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("777197eb-ea16-4f01-b20a-aa5d2ef1b0f3"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("84c7081c-eeef-4400-9669-b58ceb9eea2b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("39a3482a-a8f1-45a2-9148-91709d82b251"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e15d9ff1-a786-4495-9b37-364dff2018a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fb426c06-e1ee-49e1-bdcd-21b30b99c7dd"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1d0cafc4-b486-4127-a21f-c960e5ceafab"), "Sports", null },
                    { new Guid("39a3482a-a8f1-45a2-9148-91709d82b251"), "Races", null },
                    { new Guid("3fcd7960-7640-4be3-8ed5-0617962d2adc"), "Puzzle & Skill", null },
                    { new Guid("62eeec67-2673-4698-b895-5d98f3ba707f"), "RPG", null },
                    { new Guid("89dbce53-1959-4e0f-a39e-5887b650acfb"), "Adventure", null },
                    { new Guid("e15d9ff1-a786-4495-9b37-364dff2018a0"), "Action", null },
                    { new Guid("fb426c06-e1ee-49e1-bdcd-21b30b99c7dd"), "Strategy", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("40aa071c-e2d4-49bc-9a9f-9d7bb648eea5"), "Desktop" },
                    { new Guid("44735e98-ddf4-428f-98e9-4bb6665c1ee8"), "Console" },
                    { new Guid("777197eb-ea16-4f01-b20a-aa5d2ef1b0f3"), "Mobile" },
                    { new Guid("84c7081c-eeef-4400-9669-b58ceb9eea2b"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("2c301325-33cf-4258-9423-8f997e09833b"), "Arcade", new Guid("39a3482a-a8f1-45a2-9148-91709d82b251") },
                    { new Guid("827b7110-c634-47c1-901c-dcd4d28fbc15"), "TBS", new Guid("fb426c06-e1ee-49e1-bdcd-21b30b99c7dd") },
                    { new Guid("91517c08-72d8-4e25-830c-2845820fbda6"), "Formula", new Guid("39a3482a-a8f1-45a2-9148-91709d82b251") },
                    { new Guid("9534f46f-8ba5-43d4-b882-2c71855fe79a"), "RTS", new Guid("fb426c06-e1ee-49e1-bdcd-21b30b99c7dd") },
                    { new Guid("9ad8f495-03a6-461d-8738-0cdf766ebdee"), "Off-road", new Guid("39a3482a-a8f1-45a2-9148-91709d82b251") },
                    { new Guid("cafcc239-5dc4-4a1c-9086-bde93ca6628f"), "Rally", new Guid("39a3482a-a8f1-45a2-9148-91709d82b251") },
                    { new Guid("d68d6dee-1f2a-4a1c-96bf-544a9cc0aca5"), "FPS", new Guid("e15d9ff1-a786-4495-9b37-364dff2018a0") },
                    { new Guid("f13a6b40-5e13-4bd1-9d3a-7f2f875cb41e"), "TPS", new Guid("e15d9ff1-a786-4495-9b37-364dff2018a0") }
                });
        }
    }
}
