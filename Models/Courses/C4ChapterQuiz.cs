namespace LMS.Models.Courses
{
    public class C4ChapterQuiz
    {
        //Scalar Property
        public int Id { get; set; }
        public string? QuizName { get; set; }

        //Navigation Property of ChapterContent
        public int ChapterContentId { get; set; }

        //Navigation Property of Quiz
        public List<C5Quiz>? QuizesID { get; set; }
    }
}
