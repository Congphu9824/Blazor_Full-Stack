using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class moi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(998), false });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(1017), false });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(1046), false });

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 23, 14, 41, 52, 117, DateTimeKind.Local).AddTicks(1126));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
