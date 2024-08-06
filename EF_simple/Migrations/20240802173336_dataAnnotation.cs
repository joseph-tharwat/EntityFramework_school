using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class dataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBirth",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "DateOfBarth");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBarth",
                table: "Students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBarth",
                table: "Students",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
