using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    public class Mercedes
    {
        public string StartEngine()
        {
            string engine = "Engine started";
            return engine;
            //Console.WriteLine("Engine started!");
        }
        public string StartEngine(int milliseconds)
        {
            return "The car is starting in " + milliseconds + " milliseconds";
        }
        public int ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            //Console.WriteLine("Remaining km:" + noOfFuelLiters / Consumption * 100);
            return noOfFuelLiters / Consumption;
        }
        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }
    }
}


