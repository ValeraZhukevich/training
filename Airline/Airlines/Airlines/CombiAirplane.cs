using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class CombiAirplane : Plane, ICarryingCapacity, IPassengerCapacity
    {
        public int CarryingCapacity { get; set; }

        public int PassangerCapacity { get; set; }

        public CombiAirplane(string name, string model, double flightLength, double tankVolume)
            : base(name, model, flightLength, tankVolume)
        {

        }

        public CombiAirplane()
        {

        }
    }
}
