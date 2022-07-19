using Rental.Rentables;
using Rental.Services;
using Rental.Users;
using System;

namespace Rental
{
    public class Program
    {
        public delegate bool FilterDelegate(IRentable rentable);
        public static void Main(string[] args)
        {
            RentableCollection rentables = new RentableCollection();
            MailService mailService = new MailService();
            RentalService rentalService = new RentalService();
            rentalService.RentableRented += mailService.OnRentableRented;
            rentalService.RentableReturned += mailService.OnRentableReturned;
            Customer customer1 = new Customer("username", "password", "test@gmail.com");
            Customer customer2 = new Customer("username2", "password2", "user@yahoo.com");
            Customer customer3 = new Customer("username3", "password3", "abc@portugalmail.pt");

            Text oliverTwist = new PaperBook(
                "Oliver Twist",
                2005,
                3.50,
                "Serial novel",
                3,
                "Charles Dickens",
                350);
            Music powerslave = new MusicCd(
                "Powerslave",
                4.99,
                1984,
                "Metal",
                2,
                "Iron Maiden",
                21.29M);
            Music pianoman = new MusicCasette(
                "Piano Man",
                1973,
                7.00,
                "Pop rock",
                "Billy Joel",
                32.35M,
                6);
            Movie topgun = new MovieDvd(
                "Top Gun",
                1986,
                4.20,
                "Drama",
                "Tom Cruise",
                2);
            void DisplayRentables(RentableCollection rentablesList, FilterDelegate filter)
            {
                foreach (IRentable rentable in rentablesList)
                {
                    if (filter(rentable))
                    {
                        Console.WriteLine(rentable);
                    }
                }
            }
            bool ReleasedLastCentury(IRentable rentable)
            {
                return rentable.ReleaseYear < 2000;
            }

            bool CheaperThan5(IRentable rentable)
            {
                return rentable.RentPrice <= 5.00;
            }

            bool IsInStock(IRentable rentable)
            {
                return rentable.Stock > 0;
            }
            rentables.Add(oliverTwist);
            rentables.Add(powerslave);
            rentables.Add(pianoman);
            rentables.Add(topgun);
            Console.WriteLine("Renting an item: ");
            rentalService.Rent(customer1, powerslave);
            rentalService.Rent(customer2, powerslave);
            rentalService.Rent(customer2, powerslave);
            Console.WriteLine("Returning an item: ");
            rentalService.Return(customer1, powerslave);
            rentalService.Return(customer3, oliverTwist);
            Console.WriteLine("Displaying items released last century: ");
            DisplayRentables(rentables, ReleasedLastCentury);
            Console.WriteLine("Displaying items cheaper than 5.00: ");
            DisplayRentables(rentables, CheaperThan5);
        }
    }
}
