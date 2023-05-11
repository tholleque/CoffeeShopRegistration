namespace CoffeeShopRegistration.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }     //There can be security issues to making Passwords public
        public string Favorite { get; set; }
        public string Milk { get; set; }


    }
}
