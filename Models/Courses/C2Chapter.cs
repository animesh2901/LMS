namespace LMS.Models.Courses
{
    public class C2Chapter
    {
        //Scalar Property
        public int Id { get; set; }
        public string? ChapterName { get; set; }

        //Navigation Property of Course
        public C1Course? CourseId { get; set; }

        //Navigation Property of ChapterContent
        public List<C3ChapterContent>? ChapterContentID { get; set;}
    }
}
