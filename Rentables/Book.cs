using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Rentables
{
    public class Book : IRentable
    {
        public Book()
        {
        }

        public Book(string name, int releaseYear, double rentPrice, string genre, int stock, string author, int noOfPages)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            Stock = stock;
            Author = author;
            NoOfPages = noOfPages;
        }

        public string Name { get; }

        public int ReleaseYear { get; }

        public double RentPrice { get; }

        public string Genre { get; }

        public int Stock { get; set; }
        public string Author { get; }
        public int NoOfPages { get; }

        public override string ToString()
        {
            return base.ToString() + ": " + Name;
        }
    }
}
