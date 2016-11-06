using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    class Apple : Fruit
    {
        public Apple(){
            Console.WriteLine("The apple has been created");
        }
        public override int getCalories() {
            return 2;
        }
    }
}
