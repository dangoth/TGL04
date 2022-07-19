namespace Rental.Rentables
{
    public abstract class Text : IRentable
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double RentPrice { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }
        public int PageCount { get; set; }
        public abstract void Read();
        public override string ToString()
        {
            return $"\"{Name}\" written by {Author}";
        }
    }
}
