using Rental.Rentables;

namespace Rental.Users
{
    public class Customer : IUser
    {
        public string Username { get; }
        public string Password { get; set; }
        public string Email { get; set; }
        public double OutstandingBalance { get; set; }
        public RentableCollection RentedItems { get; }
        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;
        }
        public Customer(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            RentedItems = new RentableCollection();
        }
    }
}
