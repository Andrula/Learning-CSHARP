using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Hunt();
            fish.Flee();

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Console.ReadLine();
        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    public class Fish : IPrey, IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Fish is hunting");
        }
        public void Flee()
        {
            Console.WriteLine("The Fish is fleeing");
        }
    }

    public class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is hunting");
        }
    }

    public class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit is fleeing");
        }
    }
}
