using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absract_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Solve this problem (I can instanziate an object of type vehicle.)
            Car car = new Car();
            Boat boat = new Boat();
            Plane plane = new Plane();
            Vehicle vehicle = new Vehicle();    
        }
    }

    public class Vehicle
    {
        int speed = 10;

        public void Go()
        {
            Console.WriteLine("The vehicle goes");
        }
    }

    public class Car : Vehicle
    {
        int speed = 120;
        int wheels = 4;
    }
    public class Boat : Vehicle
    {
        int speed = 20;
        int wheels = 0;
    }

    public class Plane : Vehicle
    {
        int speed = 1000;

        int wheels = 10;
    }
}
