using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public class ComparerByFlightLength : IComparer<Plane>
    {
        public int Compare(Plane x, Plane y)
        {
            if (x != null && y != null)
            {
                if (x.FlightLength > y.FlightLength)
                {
                    return 1;
                }
                else
                {
                    return (x.FlightLength == y.FlightLength) ? 0 : -1;
                }
            }
            else
            {
                return (y == null && x == null) ? 0 : (x != null) ? 1 : -1;
            }
        }
    }
}
