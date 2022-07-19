using System;

namespace Rental.Rentables
{
    public class MovieCasette : Movie
    {
        public MovieCasette(string name, int releaseYear, double rentPrice, string genre, string mainActor, int stock)
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
            Console.WriteLine($"Playing a movie casette {Name}");
        }
        public override string ToString()
        {
            return $"Movie casette: {base.ToString()}";
        }
    }
}
