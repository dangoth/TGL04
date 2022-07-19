using System;

namespace Rental.Rentables
{
    public class EBook : Text
    {
        public EBook(string name, int releaseYear, double rentPrice, string genre, int stock, string author, int pageCount)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            Stock = stock;
            Author = author;
            PageCount = pageCount;
        }
        public override void Read()
        {
            Console.WriteLine($"Reading an EBook {Name}");
        }
        public override string ToString()
        {
            return $"EBook: {base.ToString()}";
        }
    }
}
