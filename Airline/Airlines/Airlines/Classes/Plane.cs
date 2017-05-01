using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public abstract class Plane
    {
        protected bool isReady = true;

        public string ID { get; protected set; }
        public string Model { get; protected set; }        
        public int FlightLength { get; protected set; }
        public double FuelConsumptionPerKM { get; protected set; }
        public bool IsReady { get { return isReady; } set { isReady = value; } }
        public bool IsInFlight { get; protected set; } 
        public int FlightSpeed { get; protected set; }
    
        public Plane(string iD, string model, int flightLength, double fuelConsumptionPerKM, int flightSpeed)
        {
            ID = iD;
            Model = model;
            FlightLength = flightLength;
            FuelConsumptionPerKM = fuelConsumptionPerKM;
            FlightSpeed = FlightSpeed;
        }

        public Plane() { }
        

        public void Land()
        {
            if (IsReady)
                IsInFlight = false;
            else
                Console.WriteLine("Maybe somebody will die. God bless them...");
                IsInFlight = false;
        }

        public void TakeOff()
        {
            if (IsReady)
                IsInFlight = true;
            else
                Console.WriteLine("Sorry, the plane is out of range");
        }
    
    }
}
