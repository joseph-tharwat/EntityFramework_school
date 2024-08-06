using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class sequance4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RestartSequence(
                name: "EnteredOrder",
                startValue: 10L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RestartSequence(
                name: "EnteredOrder",
                startValue: 1L);
        }
    }
}
