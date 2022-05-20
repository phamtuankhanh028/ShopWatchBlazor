using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWatch.Server.Migrations
{
    public partial class Update2002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                column: "OriginalPrice",
                value: 300000m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                column: "OriginalPrice",
                value: 300000m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 300000m, 100000m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 300000m, 100000m });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 5, 1, 300000m, 250000m },
                    { 1, 4, 300000m, 300000m },
                    { 1, 5, 300000m, 150000m },
                    { 1, 6, 300000m, 160000m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 1 xuất sứ từ Nhật Bản -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Seiko 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam Rolex 1 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Rolex 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam Rolex 1 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Longiness 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam Seiko 2 xuất sứ từ Nhật Bản -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Seiko 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam Rolex 2 xuất sứ từ Thụy Sỹ - Pin - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Rolex 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam Longiness 2 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%", "Đồng hồ Longiness 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                column: "OriginalPrice",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                column: "OriginalPrice",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 200000m });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 200000m });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[] { 4, 1, 0m, 200000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ", "Đồng hồ Seiko 5" });
        }
    }
}
