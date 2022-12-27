using LMS.Models.Courses;
using LMS.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace LMS.DataLayer
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext()
        {
        }

        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
        {
        }


        public DbSet<C1Course> Courses { get; set; }
        public DbSet<C2Chapter> Chapters { get; set; }
        public DbSet<C3ChapterContent> ChapterContents { get; set; }
        public DbSet<C4ChapterQuiz> ChapterQuizes { get; set;}
        public DbSet<C5Quiz> Quizes { get; set; }
        
        public DbSet<U1UserRoll> UserRolls { get; set; } 
        public DbSet<U2Login> Logins { get; set; }
        public DbSet<U3Admin> Admins { get; set; }
        public DbSet<U4Teacher> Teachers { get; set; }
        public DbSet<U5Student> Students { get; set; }
    }
}
