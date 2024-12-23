using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class hi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notes_contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "contacts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "IsDeleted", "LastName", "Latitude", "Longitude", "NickName", "Place" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7095), null, new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", false, "Parker", null, null, "Spider-Man", "New York City" },
                    { 2, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7113), null, new DateTime(1970, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tony", false, "Stark", null, null, "Iron Man", "Malibu" },
                    { 3, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7115), null, new DateTime(1915, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", false, "Wayne", null, null, "Batman", "Gotham City" }
                });

            migrationBuilder.InsertData(
                table: "notes",
                columns: new[] { "Id", "ContactId", "DateCreated", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7180), "With great power comes great responsibility." },
                    { 2, 2, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7181), "I am Iron Man" },
                    { 3, 3, new DateTime(2024, 12, 23, 10, 21, 47, 442, DateTimeKind.Local).AddTicks(7182), "I'm Batman!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_notes_ContactId",
                table: "notes",
                column: "ContactId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notes");

            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
