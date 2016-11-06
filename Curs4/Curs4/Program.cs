using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fruit fruit = new Fruit();
            //Console.WriteLine(fruit.getCalories());
            //Apple apple = new Apple();
            //Console.WriteLine(apple.getCalories());
            //Orange orange = new Orange();
            // Ionatan ionatan = new Ionatan();
            //Console.WriteLine(ionatan.getCalories());
            ////////////////////////////
            //Apple a = new Ionatan();
            //Console.WriteLine(a.getCalories());
            //Ionatan i = new Ionatan();
            //Console.WriteLine(i.getCalories());
            //Fruit f = new Ionatan();
            //Console.WriteLine(f.getCalories());
            Apple a = new Apple();
            Ionatan i = new Ionatan();
            Fruit f = new Fruit();
            FruitBasket basket = new FruitBasket();
            basket.addFruit(a);
            basket.addFruit(i);
            basket.addFruit(f);
            basket.displayFruitCalories();
            Console.ReadKey();
        }
    }
}
