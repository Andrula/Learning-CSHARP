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
            /*Overriding and polymoprishui*/

            Dog Labrador = new Dog();
            Cat Persian = new Cat();

            Labrador.Speak();
            Persian.Speak();
            Console.ReadLine(); 
        }
    }

    public class Animal
    {
        public virtual void Speak ()
        {
            Console.WriteLine("Mææh");
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
}
