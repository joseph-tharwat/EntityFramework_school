using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class sequance2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "order",
                table: "std",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR EnteredOrder",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "Next Value For EnteredOrder");

            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR EnteredOrder",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "Next Value For EnteredOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "order",
                table: "std",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For EnteredOrder",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR EnteredOrder");

            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For EnteredOrder",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR EnteredOrder");
        }
    }
}
