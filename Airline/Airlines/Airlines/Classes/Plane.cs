using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public abstract class Plane
    {
        public string ID { get; protected set; }
        public string Model { get; protected set; }        
        public int FlightLength { get; protected set; }
        public double FuelConsumptionPerKM { get; protected set; }
    
        public Plane(string iD, string model, int flightLength, double fuelConsumptionPerKM)
        {
            ID = iD;
            Model = model;
            FlightLength = flightLength;
            FuelConsumptionPerKM = fuelConsumptionPerKM;
        }

        public Plane()
        {

        }



        
   

    }
}
