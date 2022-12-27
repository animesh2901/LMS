namespace LMS.Models.Users
{
    public class U1UserRoll
    {
        //Scalar Property
        public int Id { get; set; }
        public string? UserType { get; set; }

        //Navigation Property to Login
        public List<U2Login>? LoginsID { get; set; }

        //Navigation Property to Teacher
        public List<U4Teacher>? TeachersID { get; set; }

        //Navigation Property to Admin
        public List<U3Admin>? AdminsID { get; set; }

        //Navigation Property to Student
        public List<U5Student>? StudentsID { get; set; }
    }
}
