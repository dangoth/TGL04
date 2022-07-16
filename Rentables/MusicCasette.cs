using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Rentables
{
    public class MusicCasette : IRentable
    {
        public MusicCasette(string name, int releaseYear, double rentPrice, string genre, string artist, int stock)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            Artist = artist;
            Stock = stock;
        }
        public string Name { get; }
        public int ReleaseYear { get; }
        public double RentPrice { get; }
        public string Genre { get;}
        public string Artist { get; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " + Name;
        }
    }
}
