using Rental.Rentables;
using Rental.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Services
{
    public class RentalService
    {
        public delegate void RentableRentedEventHandler(object source, IRentable rentable, Customer customer);
        public event RentableRentedEventHandler RentableRented;
        public delegate void RentableReturnedEventHandler(object source, IRentable rentable, Customer customer);
        public event RentableReturnedEventHandler RentableReturned;
        public void Rent(Customer customer, IRentable rentable)
        {
            if (rentable.Stock <= 0)
            {
                Console.WriteLine($"Sorry {customer.Email}, we're out of stock for {rentable.Name}.");
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
                Console.WriteLine($"This customer does not currently have {rentable.Name} rented.");
                return;                
            }
            customer.RentedItems.Remove(rentable);
            rentable.Stock += 1;
            OnRentableReturned(rentable, customer);
        }
        protected virtual void OnRentableRented(IRentable rentable, Customer customer)
        {
            RentableRented?.Invoke(this, rentable, customer);
        }
        protected virtual void OnRentableReturned(IRentable rentable, Customer customer)
        {
            RentableReturned?.Invoke(this, rentable, customer);
        }
    }
}
