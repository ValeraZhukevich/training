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

        public CargoAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM)
            : base(id, model, flightLength, fuelConsumptionPerKM)
        {

        }

        public CargoAirplane(string id, string model, int flightLength, double fuelConsumptionPerKM, int carryingCapacity)
            : base(id, model, flightLength, fuelConsumptionPerKM)
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
                    break;

                case "747-400f":
                    FlightLength = 13500;
                    CarryingCapacity = 121;
                    FuelConsumptionPerKM = 13.88;
                    break;

            }
        }

        public CargoAirplane()
        {

        }

        public override string ToString()
        {
            return string.Format("id: {0}; model: {1}; fligth length: {2}; cargo capacity: {3}, fuel consumption per km: {4}\n",
                ID, Model, FlightLength, CarryingCapacity, FuelConsumptionPerKM);
        }


    }
}
