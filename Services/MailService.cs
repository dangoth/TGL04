using Rental.Rentables;
using Rental.Users;
using System;

namespace Rental.Services
{
    public class MailService
    {
        public void OnRentableRented(object source, IRentable rentable, Customer customer)
        {
            Console.WriteLine($"Dear {customer.Email}, you have successfully rented a {rentable} for {rentable.RentPrice}");
        }
        public void OnRentableReturned(object source, IRentable rentable, Customer customer)
        {
            Console.WriteLine($"Dear {customer.Email}, thank you for returning a {rentable}. We hope you enjoyed it!");
        }
    }
}
