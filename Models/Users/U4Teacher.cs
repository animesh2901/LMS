using LMS.Models.Courses;

namespace LMS.Models.Users
{

    public class U4Teacher
    {
        //Scalar Property
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long ContactNumber { get; set; }
        public DateTime DateOfJoining { get; set; }

        //Navigation Property to UserRoll
        public U1UserRoll? UserRollID { get; set; }

        //Navigation Property to Course
        public List<C1Course>? CoursesID { get; set; }
    }
}
