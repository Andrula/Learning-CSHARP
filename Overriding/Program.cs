using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Overriding*/

            Dog labrador = new Dog();
            Cat persian = new Cat();
            Fish goldfish = new Fish();

            //labrador.Speak();
            //persian.Speak();
            //goldfish.Speak();

            Animal[] animals = {labrador,persian,goldfish};

            foreach (Animal animal in animals)
            {
                animal.Speak();
            }


            Console.ReadLine(); 
        }
    }

    public class Animal
    {
        public virtual void Speak () // Virtual makes it possible for a method or proprerty etc. to be overriden in a derived class.
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Vov!");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Miav!");
        }
    }

    public class Fish : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Plop!");
        }
    }
}
