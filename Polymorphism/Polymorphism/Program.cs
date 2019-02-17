using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals c = new Chicken();
            Animals b = new Duck();
            Animals d = new Cow();
            c.speak();
            b.speak();
            d.speak();
            Animals[] animals = { c, b, d };
            foreach(var x in animals)
            {
                x.speak();
            }
            Console.ReadKey();
        }
    }
    class Animals
    {
        public virtual void speak() //virtual in parent
        {
            Console.WriteLine("I can");
        }
    }
    class Chicken : Animals
    {
        public override void speak()
        {
            Console.WriteLine("Cluck cluck ");
        }//override
    }
    class Duck : Animals
    {
        public override void speak() //override
        {
            Console.WriteLine("Quack quack");
        }
    }
    class Cow : Animals
    {
        public override void speak() //override
        {
            Console.WriteLine("Moo moo");
        }
    }
}
