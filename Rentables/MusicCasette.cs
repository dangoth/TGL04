namespace Rental.Rentables
{
    public class MusicCasette : Music
    {
        public MusicCasette(string name, int releaseYear, double rentPrice, string genre, string artist, decimal duration, int stock)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            Artist = artist;
            Duration = duration;
            Stock = stock;
        }
        public override void Listen()
        {
            System.Console.WriteLine($"Playing a music casette {Name}");
        }
        public override string ToString()
        {
            return $"Music casette: {base.ToString()}";
        }
    }
}
