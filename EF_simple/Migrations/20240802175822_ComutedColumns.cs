using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class ComutedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalGrade",
                table: "Grades",
                type: "real",
                nullable: false,
                computedColumnSql: "[Physics] + [Math] + [Arabic]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalGrade",
                table: "Grades");
        }
    }
}
