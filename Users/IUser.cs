namespace Rental.Users
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; set; }
        string Email { get; }
        void ChangePassword(string newPassword);
    }
}
