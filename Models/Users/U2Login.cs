namespace LMS.Models.Users
{
    public class U2Login
    {
        //Scalar Property
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Navigation Property of UserRoll
        public U1UserRoll? UserRollID { get; set; }

}
}
