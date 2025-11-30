using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 1, 19, 49, 348, DateTimeKind.Local).AddTicks(7292), "Black", "System", new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(6762) },
                    { 2, "System", new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(8861), "Blue", "System", new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(8865) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
