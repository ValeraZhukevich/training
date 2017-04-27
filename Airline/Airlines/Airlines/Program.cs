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
            PassengerAirplane a380 = new PassengerAirplane("2548", "a380");
            Console.WriteLine(a380);

            CargoAirplane a330 = new CargoAirplane("2658", "a330-200f");
            Console.WriteLine(a330);
            

            

            Console.ReadKey();


        }
    }
}
