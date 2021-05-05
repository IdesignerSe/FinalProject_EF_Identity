using Microsoft.AspNetCore.Identity;

namespace MVC_Habit
{
    public class AdvancedUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public int MobileNumber { get; set; }
        public string Country { get; set; }
        public string Email2 { get; set; }
        public string PostCode { get; set; }
    }
}