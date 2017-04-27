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
   

        public PassengerAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM)
            : base(id, model, flightLength, fuelConsumptionPerKM)
        {

        }

        public PassengerAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int passangerCapacity)
            : base(id, model, flightLength, fuelConsumptionPerKM)
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
                    break;

                case "a380":
                    FlightLength = 15000;
                    PassangerCapacity = 555;
                    FuelConsumptionPerKM = 20.66;
                    break;

                case "737":
                    FlightLength = 5400;
                    PassangerCapacity = 160;
                    FuelConsumptionPerKM = 4.81;
                    break;

                case "747":
                    FlightLength = 1400;
                    PassangerCapacity = 524;
                    FuelConsumptionPerKM = 17.14;
                    break;
            }
        }

        public PassengerAirplane()
        {

        }

        public override string ToString()
        {
            return string.Format("id: {0}; model: {1}; fligth length: {2}; capacity of passanger: {3}, fuel consumption per km: {4} \n",
                ID, Model, FlightLength, PassangerCapacity, FuelConsumptionPerKM);
        }

    }
}
