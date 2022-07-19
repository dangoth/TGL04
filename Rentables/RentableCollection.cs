using System.Collections;
using System.Collections.Generic;

namespace Rental.Rentables
{
    public class RentableCollection : IEnumerable<IRentable>
    {
        List<IRentable> rentables = new List<IRentable>();
        public IRentable this[int index]
        {
            get { return rentables[index]; }
            set { rentables.Insert(index, value); }
        }
        public void Add(IRentable rentable)
        {
            rentables.Add(rentable);
        }
        public bool Contains(IRentable rentable)
        {
            return rentables.Contains(rentable);
        }
        public void Remove(IRentable rentable)
        {
            rentables.Remove(rentable);
        }
        public IEnumerator<IRentable> GetEnumerator()
        {
            return rentables.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
