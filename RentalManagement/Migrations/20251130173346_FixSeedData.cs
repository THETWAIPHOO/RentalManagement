using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 17, 19, 50, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 1, 1, 19, 49, 348, DateTimeKind.Local).AddTicks(7292), new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(8861), new DateTime(2025, 12, 1, 1, 19, 49, 350, DateTimeKind.Local).AddTicks(8865) });
        }
    }
}
