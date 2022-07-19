namespace Rental.Rentables
{
    public abstract class Music : IRentable
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double RentPrice { get; set; }
        public string Genre { get; set; }
        public int Stock { get; set; }
        public string Artist { get; set; }
        public decimal Duration { get; set; }
        public abstract void Listen();
        public override string ToString()
        {
            return $"\"{Name}\" played by {Artist}";
        }
    }
}
