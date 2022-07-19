namespace Rental.Rentables
{
    public class PaperBook : Text
    {
        public PaperBook(string name, int releaseYear, double rentPrice, string genre, int stock, string author, int pageCount)
        {
            Name = name;
            ReleaseYear = releaseYear;
            RentPrice = rentPrice;
            Genre = genre;
            Stock = stock;
            Author = author;
            PageCount = pageCount;
        }
        public int NoOfPages { get; }
        public override void Read()
        {
            System.Console.WriteLine($"Reading a paper book {Name}");
        }
        public override string ToString()
        {
            return $"Paper book: {base.ToString()}";
        }
    }
}
