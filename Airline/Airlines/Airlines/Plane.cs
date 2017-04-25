using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public abstract class Plane
    {
        protected string Name { get; set; }
        protected string Model { get; set; }        
        protected double FlightLength { get; set; }
        protected double TankVolume { get; set; }

        public Plane(string name, string model, double flightLength, double tankVolume)
        {
            Name = name;
            Model = model;
            FlightLength = flightLength;
            TankVolume = tankVolume;
        }

        public Plane()
        {

        }
   

    }
}
