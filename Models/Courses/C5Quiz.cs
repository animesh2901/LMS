namespace LMS.Models.Courses
{
    public class C5Quiz
    {
        //Scalar Property
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? OptionA { get; set; }
        public string? OptionB { get; set; }
        public string? OptionC { get; set; }
        public string? OptionD { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Discription { get; set; }

        //Navigation Property of ChapterQuiz
        public int ChapterQuizID { get; set; }        
    }
}
