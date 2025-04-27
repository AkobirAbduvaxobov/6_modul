using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreWebApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publisher_PublisherId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("07e92e87-b945-46a2-bbf3-1dac254e8ce5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0cf6686c-dc8b-4ebf-abbd-72f848988f21"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3a6306a8-009e-4de6-9024-bd2930ba8d0d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("59dc7cbe-24dc-49c0-b006-73522746bcee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6488d748-6091-4eee-9cf4-fefd3c86b3a4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d8bdf9e-3723-4139-84a0-442260cc8b98"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("84bec329-6b48-4eb9-a79a-9e7bdc0f1269"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4404352-ec01-4037-bd1b-b536100e5107"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b068099f-9260-422c-860e-32f0ed136daf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b925b01b-4d60-4516-9e3e-34c65f6b6b11"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d328a361-eb0e-4abf-8837-4ad36382ec0c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f26aab11-aa3a-40f4-8348-d24f795a0b66"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("23a151aa-c310-4541-8546-a7e2157b0881"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("26f4ea19-33a3-4250-8ce2-d1343ad56535"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("2fd39690-2a6a-490c-89d2-60e49bf9a59a"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("4cf08d4f-14a9-4bfe-a0c0-e9c76890bae9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("08e541db-5309-4fa0-9eba-a0acaf490401"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea"));

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "Publishers");

            migrationBuilder.RenameIndex(
                name: "IX_Publisher_CompanyName",
                table: "Publishers",
                newName: "IX_Publishers_CompanyName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

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

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisher");

            migrationBuilder.RenameIndex(
                name: "IX_Publishers_CompanyName",
                table: "Publisher",
                newName: "IX_Publisher_CompanyName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("08e541db-5309-4fa0-9eba-a0acaf490401"), "Races", null },
                    { new Guid("0cf6686c-dc8b-4ebf-abbd-72f848988f21"), "Adventure", null },
                    { new Guid("3a6306a8-009e-4de6-9024-bd2930ba8d0d"), "RPG", null },
                    { new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca"), "Action", null },
                    { new Guid("59dc7cbe-24dc-49c0-b006-73522746bcee"), "Sports", null },
                    { new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea"), "Strategy", null },
                    { new Guid("f26aab11-aa3a-40f4-8348-d24f795a0b66"), "Puzzle & Skill", null }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("23a151aa-c310-4541-8546-a7e2157b0881"), "Mobile" },
                    { new Guid("26f4ea19-33a3-4250-8ce2-d1343ad56535"), "Browser" },
                    { new Guid("2fd39690-2a6a-490c-89d2-60e49bf9a59a"), "Console" },
                    { new Guid("4cf08d4f-14a9-4bfe-a0c0-e9c76890bae9"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("07e92e87-b945-46a2-bbf3-1dac254e8ce5"), "Rally", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("6488d748-6091-4eee-9cf4-fefd3c86b3a4"), "TBS", new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea") },
                    { new Guid("7d8bdf9e-3723-4139-84a0-442260cc8b98"), "TPS", new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca") },
                    { new Guid("84bec329-6b48-4eb9-a79a-9e7bdc0f1269"), "FPS", new Guid("575cc9f9-7c97-42b0-9cbc-5afd5a0005ca") },
                    { new Guid("a4404352-ec01-4037-bd1b-b536100e5107"), "Off-road", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("b068099f-9260-422c-860e-32f0ed136daf"), "Formula", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") },
                    { new Guid("b925b01b-4d60-4516-9e3e-34c65f6b6b11"), "RTS", new Guid("ec7d8253-d018-4a62-932a-8cd3f2d84cea") },
                    { new Guid("d328a361-eb0e-4abf-8837-4ad36382ec0c"), "Arcade", new Guid("08e541db-5309-4fa0-9eba-a0acaf490401") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publisher_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
