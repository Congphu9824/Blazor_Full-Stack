using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "contacts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(3923), null });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(3942), null });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(3943), null });

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 11, 27, 43, 978, DateTimeKind.Local).AddTicks(4015));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "contacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7095), false });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7113), false });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7115), false });

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7182));
        }
    }
}
