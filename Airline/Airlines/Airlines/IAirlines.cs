using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    interface IAirlines : ICollection<IPlane>
    {
        ICollection<IPlane> Airliners { get; }
        string Name { get; }
        string Model { get; }
        int FlightLength { get; }
        int TankVolume { get; }
    }
}
