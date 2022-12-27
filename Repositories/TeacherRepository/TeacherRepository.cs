using LMS.DataLayer;
using LMS.Models.Courses;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository.Teacher
{
    public class TeacherRepository
    {
        public List<C1Course> GetCourses()
        {
            LMSDbContext context = new LMSDbContext();
            return context.Courses.Include("Student").ToList();
        }
    }
}
