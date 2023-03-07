using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use static to define a static member to the type (class) itself instead of 
            // Solve the problem.

            Car Ferrari = new Car("Ferrari");
            Car Porsche = new Car("Porsche");

            Console.WriteLine(Ferrari.numbersOfCars);
            Console.WriteLine(Porsche.numbersOfCars);   
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string model;
        public int numbersOfCars;

        public Car(string _model)
        {
            this.model = _model;
            ++numbersOfCars;
        }
        
    }
}
