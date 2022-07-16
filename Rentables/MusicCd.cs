using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Rentables
{
    public class MusicCd : IRentable
    {
        public MusicCd(string name, double rentPrice, int releaseYear, string genre, int stock, string artist, string duration)
        {
            Name = name;
            RentPrice = rentPrice;
            ReleaseYear = releaseYear;
            Genre = genre;
            Stock = stock;
            Artist = artist;
            Duration = duration;
        }

        public string Name { get; }

        public double RentPrice { get; }
        public int ReleaseYear { get; }
        public string Genre { get; }
        public int Stock { get; set; }
        public string Artist { get; }
        public string Duration { get; }

        public override string ToString()
        {
            return base.ToString() + ": " + Name;
        }
    }
}
