using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes _mercedes = new Mercedes();

            //_mercedes.StartEngine();
            Console.WriteLine(_mercedes.StartEngine());
            // _m.ShowRemainingNoOfKM(200, 10);
            Console.WriteLine(_mercedes.ShowRemainingNoOfKM(200, 10));
            Console.WriteLine(_mercedes.StartEngine(30));
            Console.WriteLine(_mercedes.CalculateConsumption(4, 5, 6));
            Console.ReadLine();

        }
    }
}
