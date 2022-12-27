namespace LMS.Models.Courses
{
    public class C3ChapterContent
    {
        //Scalar Property
        public int Id { get; set; }
        public string? Content { get; set; }

        //Navigation Property of Chapter
        public int ChapterId { get; set; }

        //Navigation Property of ChapterQuiz
        public List<C4ChapterQuiz>? ChapterQuizesID { get; set; }
    }
}
