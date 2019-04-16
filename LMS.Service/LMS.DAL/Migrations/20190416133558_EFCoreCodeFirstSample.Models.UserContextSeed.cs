using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.DALL.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsUserContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(1999, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "mar@yah.com", "Marlon", "Elpedes", "06666666666" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(1989, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jess@yah.com", "Jess", "Allen", "02346666666" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L);
        }
    }
}
