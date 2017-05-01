using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class PassengerAirplane : Plane, IPassengerCapacity
    {
        public int PassangerCapacity { get; set; }
   

        public PassengerAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int flightSpeed)
            : base(id, model, flightLength, fuelConsumptionPerKM, flightSpeed)
        {

        }

        public PassengerAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int flightSpeed, int passangerCapacity)
            : base(id, model, flightLength, fuelConsumptionPerKM, flightSpeed)
        {
            PassangerCapacity = passangerCapacity;
        }

        

        public PassengerAirplane(string id, string model)
        {
            ID = id;
            Model = model;

            switch (model.ToLower())
            {
                case "a320":
                    FlightLength = 4600;
                    PassangerCapacity = 150;
                    FuelConsumptionPerKM = 4.09;
                    FlightSpeed = 840;
                    break;

                case "a380":
                    FlightLength = 15000;
                    PassangerCapacity = 555;
                    FuelConsumptionPerKM = 20.66;
                    FlightSpeed = 900;
                    break;

                case "737":
                    FlightLength = 5400;
                    PassangerCapacity = 160;
                    FuelConsumptionPerKM = 4.81;
                    FlightSpeed = 795;
                    break;

                case "747":
                    FlightLength = 14000;
                    PassangerCapacity = 524;
                    FuelConsumptionPerKM = 17.14;
                    FlightSpeed = 920;
                    break;
            }
        }

        public PassengerAirplane()
        {

        }

        public override string ToString()
        {
            return string.Format(" model: {1}\n id: {0}\n fligth length: {2}\n capacity of passanger: {3}\n fuel consumption per km: {4} \n" +
                "flight speed: {5}\n",
                ID, Model, FlightLength, PassangerCapacity, FuelConsumptionPerKM, FlightSpeed);
        }

    }
}
