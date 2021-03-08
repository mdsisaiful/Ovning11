using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Count", "Description", "Name", "Orderdate" },
                values: new object[] { "Electronic", 78, "A portable computer", "Laptop", new DateTime(2021, 3, 5, 12, 7, 1, 96, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[] { "Apple", 110, "A tablet", "IPAD", new DateTime(2021, 3, 2, 12, 7, 1, 97, DateTimeKind.Local).AddTicks(7996), 8000, "5D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Count", "Description", "Name", "Orderdate" },
                values: new object[] { "Mobile", 156, "Stupid", "Iphone", new DateTime(2021, 3, 1, 14, 14, 3, 144, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[] { "Mobile", 98, "Better", "S10", new DateTime(2021, 2, 12, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(139), 12450, "4C" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 3, "Computers", 23, "Stupid", "MacBook", new DateTime(2021, 3, 2, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(159), 45600, "4C" },
                    { 4, "Computer", 32, "Stupid", "Surface X", new DateTime(2021, 1, 26, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(163), 26850, "5C" },
                    { 5, "Office Supplies", 15651, "Stupid", "Pen", new DateTime(2021, 3, 1, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(166), 1, "45W" }
                });
        }
    }
}
