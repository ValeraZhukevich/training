using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class CargoAirplane : Plane, ICarryingCapacity
    {
        public int CarryingCapacity { get; set; }

        public CargoAirplane(string name, string model, double flightLength, double tankVolume)
            : base(name, model, flightLength, tankVolume)
        {

        }

        public CargoAirplane()
        {

        }
    }
}
