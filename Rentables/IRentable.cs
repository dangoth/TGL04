using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.Rentables
{
    public interface IRentable
    {
        string Name { get; }
        int ReleaseYear { get; }
        double RentPrice { get; }
        string Genre { get; }
        int Stock { get; set; }

    }
}
