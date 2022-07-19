using Rental.Rentables;
using Rental.Users;
using System;

namespace Rental.Services
{
    public class RentalService
    {
        public delegate void RentableRentedEventHandler(object source, IRentable rentable, Customer customer);
        public event RentableRentedEventHandler RentableRented = (source, rentable, customer) => { };
        public delegate void RentableReturnedEventHandler(object source, IRentable rentable, Customer customer);
        public event RentableReturnedEventHandler RentableReturned = (source, rentable, customer) => { };
        public void Rent(Customer customer, IRentable rentable)
        {
            if (rentable.Stock <= 0)
            {
                Console.WriteLine($"Sorry {customer.Email}, we're out of stock for {rentable}.");
                return;
            }
            rentable.Stock -= 1;
            customer.OutstandingBalance += rentable.RentPrice;
            customer.RentedItems.Add(rentable);
            OnRentableRented(rentable, customer);
        }
        public void Return(Customer customer, IRentable rentable)
        {
            if (!customer.RentedItems.Contains(rentable))
            {
                Console.WriteLine($"This customer does not currently have the {rentable} rented.");
                return;
            }
            customer.RentedItems.Remove(rentable);
            rentable.Stock += 1;
            OnRentableReturned(rentable, customer);
        }
        protected virtual void OnRentableRented(IRentable rentable, Customer customer)
        {
            RentableRented.Invoke(this, rentable, customer);
        }
        protected virtual void OnRentableReturned(IRentable rentable, Customer customer)
        {
            RentableReturned.Invoke(this, rentable, customer);
        }
    }
}
