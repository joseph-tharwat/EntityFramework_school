using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class sequance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "EnteredOrder");

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "std",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For EnteredOrder");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For EnteredOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "std");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Books");

            migrationBuilder.DropSequence(
                name: "EnteredOrder");
        }
    }
}
