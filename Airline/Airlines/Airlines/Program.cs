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

            Airlines belavia = new Airlines();

            belavia.Add(new PassengerAirplane("25687", "a320"));
            belavia.Add(new PassengerAirplane("10236", "a380"));
            belavia.Add(new PassengerAirplane("98571", "747"));
            belavia.Add(new CargoAirplane("54782", "a330-200f"));
            belavia.Add(new CargoAirplane("45785", "IL-76", 4000, 27.25) { CarryingCapacity = 60 });

            Console.WriteLine("{0}'s list of airplanes", belavia.Name);

            foreach (Plane a in belavia)
            {
                Console.WriteLine(a);
            }

            
            

            

            Console.ReadKey();


        }
    }
}
