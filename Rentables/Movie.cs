namespace Rental.Rentables
{
    public abstract class Movie : IRentable
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double RentPrice { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }
        public string MainActor { get; set; }
        public abstract void PlayMovie();
        public override string ToString()
        {
            return $"\"{Name}\" starring {MainActor}";
        }
    }
}
