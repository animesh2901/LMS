using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Migrations
{
    /// <inheritdoc />
    public partial class GetUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string getUserRole = @"CREATE PROC USER_ROLE (
                                    @USERNAME NVARCHAR(50) )
                                    AS BEGIN 
                                    SELECT L.UserRollIDId FROM Logins L WHERE L.UserName = @USERNAME
                                    END;";
            migrationBuilder.Sql(getUserRole);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string valid_login_procedure = @"DROP PROC USER_ROLE";
            migrationBuilder.Sql(valid_login_procedure);
        }
    }
}
