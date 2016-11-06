using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes _mercedes = new Mercedes();
            EngineStruct engine = new EngineStruct();
            ICar _car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            Mercedes _m = new Mercedes(4, "verde");
            Console.WriteLine("This is my first C# project!");
            Console.WriteLine("Mercedes is: " + _mercedes.Description + " and has the price: " + _mercedes.Price);
            Console.WriteLine("Culoare: " +_m.color + ", nr. roti: " + _m.wheelsNumber);
            Audi a = new Audi();
            Console.WriteLine(a.carStarted);
            Console.ReadLine();
            
        }
    }
}
