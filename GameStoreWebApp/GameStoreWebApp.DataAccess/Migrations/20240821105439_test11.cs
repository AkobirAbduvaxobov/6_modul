using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("3627a97a-511b-4170-a787-3abe9e9d6b3d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("ca3b4a01-fbb8-44f3-bc48-a272986f7f16"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("f33b77cd-717d-4636-ad74-9308f9466a4b"));

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

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId_ParentCommentId",
                table: "Comments",
                columns: new[] { "GameId", "ParentCommentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
    }
}
