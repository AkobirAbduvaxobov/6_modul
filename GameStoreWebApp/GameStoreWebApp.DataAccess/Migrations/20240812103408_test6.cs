using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0d502b12-6a6b-4c52-ab81-17b35006ba6b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6b9b5ec0-c8da-4cba-b227-0456c4dda189"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6ca6a3eb-6e7c-446e-bc0f-57ee94d6a1df"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d48b576-7d32-4b40-89a8-2c572798577c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("92d6daf8-f045-4b78-8251-a6409a7e1820"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bddf5ef3-a0a9-4a4f-9da1-0a03441afab9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("caeec65d-f86a-4aab-bc29-102ebccfb087"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d353dded-d382-460a-9132-762c732b5e03"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d49ff861-8b31-4727-ab45-47732a059ddf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eaa8be15-1cc9-4144-b7d9-0c207c3eea60"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f3463764-d0c5-4033-b6eb-6178713f0c2e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f735f5c5-3435-4444-984c-77b8033a8b12"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("83c76ea8-b250-44df-b8b4-8f5f354a3317"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a0f45f5d-93d2-42e6-9ec2-35a2d43bb57f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("ab0e67d8-2983-4fe9-a6bb-97ef2e8da0df"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("f07f63be-52dd-4d25-a4d9-45b204e832f9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1537355c-264d-4da2-a18b-5dd3d608d919"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("18056a0c-a28b-4b0f-b340-0597356fed6a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3ef3b282-219f-4cbf-8a16-5a19422f974f"));

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderGame",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGame", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderGame_Games_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderGame_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderGame_ProductId",
                table: "OrderGame",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderGame");

            migrationBuilder.DropTable(
                name: "Order");

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
                    { new Guid("1537355c-264d-4da2-a18b-5dd3d608d919"), "Races", null },
                    { new Guid("18056a0c-a28b-4b0f-b340-0597356fed6a"), "Action", null },
                    { new Guid("3ef3b282-219f-4cbf-8a16-5a19422f974f"), "Strategy", null },
                    { new Guid("6b9b5ec0-c8da-4cba-b227-0456c4dda189"), "Adventure", null },
                    { new Guid("bddf5ef3-a0a9-4a4f-9da1-0a03441afab9"), "Puzzle & Skill", null },
                    { new Guid("caeec65d-f86a-4aab-bc29-102ebccfb087"), "RPG", null },
                    { new Guid("eaa8be15-1cc9-4144-b7d9-0c207c3eea60"), "Sports", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("83c76ea8-b250-44df-b8b4-8f5f354a3317"), "Browser" },
                    { new Guid("a0f45f5d-93d2-42e6-9ec2-35a2d43bb57f"), "Desktop" },
                    { new Guid("ab0e67d8-2983-4fe9-a6bb-97ef2e8da0df"), "Console" },
                    { new Guid("f07f63be-52dd-4d25-a4d9-45b204e832f9"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0d502b12-6a6b-4c52-ab81-17b35006ba6b"), "TBS", new Guid("3ef3b282-219f-4cbf-8a16-5a19422f974f") },
                    { new Guid("6ca6a3eb-6e7c-446e-bc0f-57ee94d6a1df"), "Off-road", new Guid("1537355c-264d-4da2-a18b-5dd3d608d919") },
                    { new Guid("7d48b576-7d32-4b40-89a8-2c572798577c"), "Arcade", new Guid("1537355c-264d-4da2-a18b-5dd3d608d919") },
                    { new Guid("92d6daf8-f045-4b78-8251-a6409a7e1820"), "Formula", new Guid("1537355c-264d-4da2-a18b-5dd3d608d919") },
                    { new Guid("d353dded-d382-460a-9132-762c732b5e03"), "TPS", new Guid("18056a0c-a28b-4b0f-b340-0597356fed6a") },
                    { new Guid("d49ff861-8b31-4727-ab45-47732a059ddf"), "FPS", new Guid("18056a0c-a28b-4b0f-b340-0597356fed6a") },
                    { new Guid("f3463764-d0c5-4033-b6eb-6178713f0c2e"), "Rally", new Guid("1537355c-264d-4da2-a18b-5dd3d608d919") },
                    { new Guid("f735f5c5-3435-4444-984c-77b8033a8b12"), "RTS", new Guid("3ef3b282-219f-4cbf-8a16-5a19422f974f") }
                });
        }
    }
}
