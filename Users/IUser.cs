using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
