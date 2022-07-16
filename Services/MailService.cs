using Rental.Rentables;
using Rental.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Services
{
    public class MailService
    {
        public void OnRentableRented(object source, IRentable rentable, Customer customer)
        {
            Console.WriteLine($"Dear {customer.Email}, you have successfully rented {rentable.Name} for {rentable.RentPrice}");
        }

        public void OnRentableReturned(object source, IRentable rentable, Customer customer)
        {
            Console.WriteLine($"Dear {customer.Email}, thank you for returning {rentable.Name}. We hope you enjoyed it!");
        }
    }
}
