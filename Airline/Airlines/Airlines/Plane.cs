using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    interface IPlane
    {
        string Name { get; set; }
        string Model { get; set; }        
        int FlightLength { get; set; }
        int TankVolume { get; set; }

        
   

    }
}
