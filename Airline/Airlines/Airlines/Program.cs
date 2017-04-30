using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class Program
    {
        static void Main(string[] args)
        {

            Airlines belavia = new Airlines("BelAvia");

            belavia.Add(new PassengerAirplane("25687", "a320"));            
            belavia.Add(new PassengerAirplane("98571", "747"));
            belavia.Add(new PassengerAirplane("10236", "a380"));
            belavia.Add(new CargoAirplane("45785", "IL-76", 4000, 27.25) { CarryingCapacity = 60 });
            belavia.Add(new CargoAirplane("54782", "a330-200f"));

            Console.WriteLine("{0}'s list of airplanes", belavia.Name);
            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Plane a in belavia)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("{0}'s list of airplanes after sorting by flight length", belavia.Name);
            Console.WriteLine("--------------------------------------------------------------------");

            belavia.SortByFlightLength();

            foreach (Plane a in belavia)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("{0}'s total capacity of passengers: {1} peoples \n", belavia.Name, belavia.GetTotalPassangerCapacity());
            Console.WriteLine("{0}'s total carrying capacity: {1} tones\n", belavia.Name, belavia.GetTotalCarryingCapacity());

            Console.WriteLine("To find suitable airplane in fuel consumption per km");
            Console.WriteLine("----------------------------------------------------");

            ShowSuitablePlanes.Show(belavia, 10.0);
            

            Console.ReadKey();
        }
    }
}
