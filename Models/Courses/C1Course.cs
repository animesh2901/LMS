namespace LMS.Models.Courses
{
    public class C1Course
    {
        //Scalar Property
        public int Id { get; set; }
        public string? CourseName { get; set; }

        //Navigation Property
        public List<C2Chapter>? ChapterID { get; set; }
    }
}
