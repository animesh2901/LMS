using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Migrations
{
    /// <inheritdoc />
    public partial class ValidLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string valid_login_procedure = @"CREATE PROC Valid_Login
                                            (
                                            @USERNAME NVARCHAR(50), @PASSWORD NVARCHAR(250)
                                            ) AS BEGIN
                                            SELECT * FROM LOGINS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD
                                            END;";
            migrationBuilder.Sql(valid_login_procedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string valid_login_procedure = @"DROP PROC Valid_Login";
            migrationBuilder.Sql(valid_login_procedure);
        }
    }
}
