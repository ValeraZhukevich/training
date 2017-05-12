using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcer parc = new Parcer();
            parc.Send("TestText.txt");

            parc.WriteToFile("Result.txt");

            Console.ReadKey();

        }
    }
}
