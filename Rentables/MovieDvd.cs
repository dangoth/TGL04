using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Rentables
{
    public class MovieDvd : IRentable
    {
        public MovieDvd(string name, int releaseYear, double rentPrice, int stock, string genre, double rating)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Stock = stock;
            Genre = genre;
            Rating = rating;
        }

        public string Name { get; }

        public int ReleaseYear { get; }

        public double RentPrice { get; }
        public int Stock { get; set; }
        public string Genre { get; }
        public double Rating { get; }

        public override string ToString()
        {
            return base.ToString() + ": " + Name;
        }
    }
}
