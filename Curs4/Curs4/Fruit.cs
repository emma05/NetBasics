using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    public class Fruit
    {
        public Fruit(){
            Console.WriteLine("The fruit has been created");
        }
        public virtual int getCalories() {
            return 1;
        }
        private class Sambure {
        }
    }
}
