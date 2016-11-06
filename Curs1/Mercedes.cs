using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    public class Mercedes : AbstractCar
    {
        private string _description;
        private int _price;
        protected int year;
        protected string power;
        internal string color;
        internal int wheelsNumber;
        public string Description {
            get{return _description;}
            set{_description = "E Class";}
        }
        public int Price{
            get {return _price; }
            set { _price = 20000; }
        }
        public Mercedes(){
            _description = "E class";
            _price = 170000;
        }
        public Mercedes(int roti, string cul) {
            wheelsNumber = roti;
            color = cul;
        }
    }
}
