using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public class Airlines : ICollection<Plane>
    {
        int totalLoadCapacity = 0;
        int totalPassangerCapacity = 0;

        private ICollection<Plane> airliners = new List<Plane>();

        public int Count
        {
            get { return airliners.Count; }
        }

        public bool IsReadOnly
        {
            get { return airliners.IsReadOnly; }
        }

        public void Add(Plane unit)
        {
            airliners.Add(unit);
        }

        public void Clear()
        {
            airliners.Clear();
        }

        public bool Contains(Plane unit)
        {
            return airliners.Contains(unit);
        }

        public void CopyTo(Plane[] array, int arrayIndex)
        {
            airliners.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Plane> GetEnumerator()
        {
            return airliners.GetEnumerator();
        }

        public bool Remove(Plane unit)
        {
            return airliners.Remove(unit);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        protected void Sort(IComparer<Plane> comparer)
        {
            var newList = airliners.ToList();
            newList.Sort(comparer);
            airliners = newList;
        }

        public void SortByFlightLength()
        {
            Sort(new ComparerByFlightLength());
        }

       

    }

}
