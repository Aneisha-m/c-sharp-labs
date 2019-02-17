using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            Animal a = new Animal();
            a.Move();
            a.Speak();
        }
    }
    abstract class Parent
    {
        public virtual void doThis()
        {

        }
        public abstract int doThisAgain();
    }
    abstract class Animal
    {
        public void Move()
        {
            Console.WriteLine("move");
        }
        public abstract void Speak()
        {
            Console.WriteLine("speak");
        }
    }
    class Duck : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("quack quack");
        }
    }
    //interfaces
    interface IUseThisSetOfTools
    {
        void Move();
        void Speak();
    }

    class Human : IUseThisSetOfTools
    {
        public void Move()
        {
            Console.WriteLine("Let's Rock and Roll");
        }
        public void Speak()
        {
            Console.WriteLine("Yes I am not an Animal");
        }
    }
}
