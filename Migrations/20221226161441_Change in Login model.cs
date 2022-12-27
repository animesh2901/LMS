using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Migrations
{
    /// <inheritdoc />
    public partial class ChangeinLoginmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Admins_AdminIDId",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Students_StudentStudentIDId",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Teachers_TeacherIDId",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_AdminIDId",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_StudentStudentIDId",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_TeacherIDId",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "AdminIDId",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "StudentStudentIDId",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "TeacherIDId",
                table: "Logins");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Logins",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Logins",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "AdminIDId",
                table: "Logins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentStudentIDId",
                table: "Logins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherIDId",
                table: "Logins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_AdminIDId",
                table: "Logins",
                column: "AdminIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_StudentStudentIDId",
                table: "Logins",
                column: "StudentStudentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_TeacherIDId",
                table: "Logins",
                column: "TeacherIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Admins_AdminIDId",
                table: "Logins",
                column: "AdminIDId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Students_StudentStudentIDId",
                table: "Logins",
                column: "StudentStudentIDId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Teachers_TeacherIDId",
                table: "Logins",
                column: "TeacherIDId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
