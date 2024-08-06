using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class sequance5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnteredOrder",
                table: "std",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "EnteredOrder",
                table: "Books",
                newName: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "std",
                newName: "EnteredOrder");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Books",
                newName: "EnteredOrder");
        }
    }
}
