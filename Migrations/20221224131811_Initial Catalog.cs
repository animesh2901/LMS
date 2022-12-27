using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRollIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_UserRolls_UserRollIDId",
                        column: x => x.UserRollIDId,
                        principalTable: "UserRolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRollIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_UserRolls_UserRollIDId",
                        column: x => x.UserRollIDId,
                        principalTable: "UserRolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRollIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_UserRolls_UserRollIDId",
                        column: x => x.UserRollIDId,
                        principalTable: "UserRolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U4TeacherId = table.Column<int>(type: "int", nullable: true),
                    U5StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Students_U5StudentId",
                        column: x => x.U5StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_U4TeacherId",
                        column: x => x.U4TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRollIDId = table.Column<int>(type: "int", nullable: true),
                    AdminIDId = table.Column<int>(type: "int", nullable: true),
                    TeacherIDId = table.Column<int>(type: "int", nullable: true),
                    StudentStudentIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Admins_AdminIDId",
                        column: x => x.AdminIDId,
                        principalTable: "Admins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Logins_Students_StudentStudentIDId",
                        column: x => x.StudentStudentIDId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Logins_Teachers_TeacherIDId",
                        column: x => x.TeacherIDId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Logins_UserRolls_UserRollIDId",
                        column: x => x.UserRollIDId,
                        principalTable: "UserRolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseIdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Courses_CourseIdId",
                        column: x => x.CourseIdId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChapterContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    C2ChapterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterContents_Chapters_C2ChapterId",
                        column: x => x.C2ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChapterQuizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterContentId = table.Column<int>(type: "int", nullable: false),
                    C3ChapterContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterQuizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterQuizes_ChapterContents_C3ChapterContentId",
                        column: x => x.C3ChapterContentId,
                        principalTable: "ChapterContents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterQuizID = table.Column<int>(type: "int", nullable: false),
                    C4ChapterQuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizes_ChapterQuizes_C4ChapterQuizId",
                        column: x => x.C4ChapterQuizId,
                        principalTable: "ChapterQuizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserRollIDId",
                table: "Admins",
                column: "UserRollIDId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterContents_C2ChapterId",
                table: "ChapterContents",
                column: "C2ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterQuizes_C3ChapterContentId",
                table: "ChapterQuizes",
                column: "C3ChapterContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseIdId",
                table: "Chapters",
                column: "CourseIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_U4TeacherId",
                table: "Courses",
                column: "U4TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_U5StudentId",
                table: "Courses",
                column: "U5StudentId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserRollIDId",
                table: "Logins",
                column: "UserRollIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizes_C4ChapterQuizId",
                table: "Quizes",
                column: "C4ChapterQuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserRollIDId",
                table: "Students",
                column: "UserRollIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserRollIDId",
                table: "Teachers",
                column: "UserRollIDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Quizes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ChapterQuizes");

            migrationBuilder.DropTable(
                name: "ChapterContents");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "UserRolls");
        }
    }
}
