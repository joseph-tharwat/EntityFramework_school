using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_simple.Migrations
{
    /// <inheritdoc />
    public partial class dataAnnotationFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "std");

            migrationBuilder.RenameColumn(
                name: "DateOfBarth",
                table: "std",
                newName: "studentName");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentId",
                table: "std",
                newName: "IX_std_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_std",
                table: "std",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_std_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "std",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_std_Departments_DepartmentId",
                table: "std",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_std_StudentId",
                table: "StudentBooks",
                column: "StudentId",
                principalTable: "std",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_std_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_std_Departments_DepartmentId",
                table: "std");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_std_StudentId",
                table: "StudentBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_std",
                table: "std");

            migrationBuilder.RenameTable(
                name: "std",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "studentName",
                table: "Students",
                newName: "DateOfBarth");

            migrationBuilder.RenameIndex(
                name: "IX_std_DepartmentId",
                table: "Students",
                newName: "IX_Students_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Students_StudentId",
                table: "StudentBooks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
