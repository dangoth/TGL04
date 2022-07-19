namespace Rental.Rentables
{
    public class MusicCd : Music
    {
        public MusicCd(string name, double rentPrice, int releaseYear, string genre, int stock, string artist, decimal duration)
        {
            Name = name;
            RentPrice = rentPrice;
            ReleaseYear = releaseYear;
            Genre = genre;
            Stock = stock;
            Artist = artist;
            Duration = duration;
        }
        public override void Listen()
        {
            System.Console.WriteLine($"Playing a music CD {Name}");
        }
        public override string ToString()
        {
            return $"Music CD: {base.ToString()}";
        }
    }
}
