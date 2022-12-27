namespace LMS.Models.Users
{
    public class U3Admin
    {
        //Scalar Property
        public int Id { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfRegistration { get; set; }

        //Navigation Property to UserRoll
        public U1UserRoll? UserRollID { get; set; }
    }
}
