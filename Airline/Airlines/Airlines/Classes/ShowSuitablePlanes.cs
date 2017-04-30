using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    public class ShowSuitablePlanes
    {
        public static void Show(Airlines airliners, double petrolEfficient)
        {
            List<Plane> suitablePlanes = airliners.ToFindSuitablePlane(petrolEfficient);
            foreach (Plane a in suitablePlanes)
            {
                Console.WriteLine(a);
            }
        }
    }
}
