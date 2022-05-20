using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWatch.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "Seiko", "Seiko", "seiko" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "Rolex", "Rolex", "rolex" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "Longginess", "Longiness", "longiness" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 15, 21, 21, 56, 695, DateTimeKind.Local).AddTicks(9493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/4/46/Seiko-5-blue-gold.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" },
                    { 4, 1, new DateTime(2022, 4, 15, 21, 21, 56, 698, DateTimeKind.Local).AddTicks(2108), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/9/97/Rolex_Datejust_36_-_On_Display_%2850826140918%29.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" },
                    { 2, 2, new DateTime(2022, 4, 15, 21, 21, 56, 698, DateTimeKind.Local).AddTicks(2078), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/c/c0/Seiko_Sportura_Chronograph_H023-00A0%2C_2003.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" },
                    { 5, 2, new DateTime(2022, 4, 15, 21, 21, 56, 698, DateTimeKind.Local).AddTicks(2175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/e/ed/Rolex_Datejust_Oysterquartz.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" },
                    { 3, 3, new DateTime(2022, 4, 15, 21, 21, 56, 698, DateTimeKind.Local).AddTicks(2105), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/0/08/Rolex_Daytona_Cosmograph.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" },
                    { 6, 3, new DateTime(2022, 4, 15, 21, 21, 56, 698, DateTimeKind.Local).AddTicks(2179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "https://upload.wikimedia.org/wikipedia/commons/1/12/Rolex_5100.jpg", false, false, 19.99m, 9.99m, "Đồng hồ Seiko 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
