using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public class ShowSuitablePlanes
    {
        public static void ShowByFuel(Airlines airliners, double fuelEfficient)
        {
            List<Plane> suitablePlanes = airliners.FindSuitablePlaneByFuel(fuelEfficient);
            if (suitablePlanes.Count != 0)
            {
                Console.WriteLine("Suitable planes by fuel efficient");
                foreach (Plane a in suitablePlanes)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Sorry... There aren't suitable planes");
            }
        }

        public static void ShowByTime(Airlines airliners, int tripDistance, TimeSpan interval)
        {
            List<Plane> suitablePlanes = airliners.FindSuitablePlaneByTime(tripDistance, interval);
            if (suitablePlanes.Count != 0)
            {
                Console.WriteLine("Suitable planes by time");
                foreach (Plane a in suitablePlanes)
                {
                    double hoursInterval = (double)tripDistance / a.FlightSpeed + 0.33;
                    int hours = (int)hoursInterval;
                    float minutes = (float)hoursInterval * 60 % 60;
                    Console.WriteLine(a);
                    Console.WriteLine("The planes take {0} hours and {1} minutes for this trip \n\n", hours, Math.Round(minutes, 2, MidpointRounding.AwayFromZero));
                }
                
            }
            else
            {
                Console.WriteLine("Sorry... There aren't suitable planes");
            }
        }
    }
}
