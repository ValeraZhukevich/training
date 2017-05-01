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
        public string Name { get;  private set; }

        public Airlines(string name)
        {
            Name = name;
        }


        public Airlines()
        {

        }
        
        private ICollection<Plane> airliners = new List<Plane>();


        public List<Plane> FindSuitablePlaneByFuel(double fuelConsumptionPerKM)
        {
            List<Plane> suitPlanes = new List<Plane>();
            foreach(Plane a in airliners)
            {
                if(a.FuelConsumptionPerKM <= fuelConsumptionPerKM)
                {
                    suitPlanes.Add(a);
                }
            }

            return suitPlanes;

        }

        public List<Plane> FindSuitablePlaneByTime(int tripDistance, TimeSpan interval)
        {
            double hours = interval.TotalHours;
            

            List<Plane> suitPlanes = new List<Plane>();
            foreach (Plane a in airliners)
            {
                if((((double)tripDistance / a.FlightSpeed) + 0.33 <= hours) && !a.IsInFlight) // 0.33 is needed time to take off and landing
                {
                    suitPlanes.Add(a);
                }
                
            }

            return suitPlanes;

        }

        int totalPassangerCapacity = 0;
        int totalCarryingCapacity = 0;

        public int GetTotalPassangerCapacity()
        {
            foreach (Plane a in airliners)
            {
                if (a is IPassengerCapacity)
                {
                    IPassengerCapacity b = (IPassengerCapacity)a;
                    totalPassangerCapacity += b.PassangerCapacity;
                }
            }
            return totalPassangerCapacity;
        }

        public int GetTotalCarryingCapacity()
        {
            foreach (Plane a in airliners)
            {
                if (a is ICarryingCapacity)
                {
                    ICarryingCapacity b = (ICarryingCapacity)a;
                    totalCarryingCapacity += b.CarryingCapacity;
                }
            }
            return totalCarryingCapacity;
        }

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
