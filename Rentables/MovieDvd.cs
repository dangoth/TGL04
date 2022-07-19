using System;

namespace Rental.Rentables
{
    public class MovieDvd : Movie
    {
        public MovieDvd(string name, int releaseYear, double rentPrice, string genre, string mainActor, int stock)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            MainActor = mainActor;
            Stock = stock;
        }
        public override void PlayMovie()
        {
            Console.WriteLine($"Playing a DVD movie {Name}");
        }
        public override string ToString()
        {
            return $"Movie DVD: {base.ToString()}";
        }
    }
}
