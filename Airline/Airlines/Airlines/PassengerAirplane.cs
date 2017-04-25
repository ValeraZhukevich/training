using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class PassengerAirplane : Plane, IPassengerCapacity
    {
        public int PassangerCapacity { get; protected set; }

        public PassengerAirplane(string name, string model, double flightLength, double tankVolume)
            : base(name, model, flightLength, tankVolume)
        {

        }

        public PassengerAirplane()
        {

        }

        
    }
}
