using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Users
{
    public class Employee : IUser
    {
        public string Username { get; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;
        }

        public string ChangeCustomerBalance(Customer customer, double amount)
        {
            if (customer.OutstandingBalance > 0)
            {
                customer.OutstandingBalance -= amount;
                return $"The new customer balance is {customer.OutstandingBalance}";
            }
            return "The customer does not have any outstanding balance";
        }
    }
}
