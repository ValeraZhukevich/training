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

        public CargoAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int flightSpeed)
            : base(id, model, flightLength, fuelConsumptionPerKM, flightSpeed)
        {

        }

        public CargoAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int flightSpeed, int carryingCapacity)
            : base(id, model, flightLength, fuelConsumptionPerKM, flightSpeed)
        {
            CarryingCapacity = carryingCapacity; //tons
        }

        public CargoAirplane(string id, string model)
        {
            ID = id;
            Model = model;

            switch (model.ToLower())
            {
                case "a330-200f":
                    FlightLength = 7400;
                    CarryingCapacity = 65;
                    FuelConsumptionPerKM = 13.18;
                    FlightSpeed = 875;
                    break;

                case "747-400f":
                    FlightLength = 13500;
                    CarryingCapacity = 121;
                    FuelConsumptionPerKM = 13.88;
                    FlightSpeed = 980;
                    break;

            }
        }

        public CargoAirplane()
        {

        }

        public override string ToString()
        {
            return string.Format("id: {0}\n model: {1}\n fligth length: {2}\n cargo capacity: {3}\n fuel consumption per km: {4}\n" +
                "flight speed: {5}\n",
                ID, Model, FlightLength, CarryingCapacity, FuelConsumptionPerKM, FlightSpeed);
        }


    }
}
