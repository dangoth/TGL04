namespace Rental.Rentables
{
    public interface IRentable
    {
        string Name { get; set; }
        int ReleaseYear { get; set; }
        double RentPrice { get; set; }
        string Genre { get; set; }
        int Stock { get; set; }
    }
}
