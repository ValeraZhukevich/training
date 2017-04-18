using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    interface IPlane
    {
        string Name { get; }
        int CapacityOfFuelTank { get; }
        int RangeOfFlight { get;  }
    }
}
