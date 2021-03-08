using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class DataAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Orderdate",
                value: new DateTime(2021, 3, 1, 14, 14, 3, 144, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Orderdate",
                value: new DateTime(2021, 2, 12, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Orderdate",
                value: new DateTime(2021, 3, 2, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Orderdate",
                value: new DateTime(2021, 1, 26, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Orderdate",
                value: new DateTime(2021, 3, 1, 14, 14, 3, 146, DateTimeKind.Local).AddTicks(166));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Orderdate",
                value: new DateTime(2021, 3, 1, 11, 18, 48, 163, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Orderdate",
                value: new DateTime(2021, 2, 12, 11, 18, 48, 164, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Orderdate",
                value: new DateTime(2021, 3, 2, 11, 18, 48, 164, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Orderdate",
                value: new DateTime(2021, 1, 26, 11, 18, 48, 164, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Orderdate",
                value: new DateTime(2021, 3, 1, 11, 18, 48, 164, DateTimeKind.Local).AddTicks(8450));
        }
    }
}
