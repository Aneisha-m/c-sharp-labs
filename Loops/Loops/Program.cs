using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops lp = new Loops();
            // 1p.LoopEx();

            //lab EX1 cumulative total of 1- 100
            int x = 0;
            for (int i = 1; i <= 100; i++)
            {
           
                x = x + 1;
                Console.WriteLine(i);
            }
            Console.WriteLine(x);

            //lab EX2 cumulative total 
            for (int i = 0; i <= 25; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }

    class Loops
    {
        int[] myArray = {2,3,5,6};
        int x = 10;
        public void LoopEx()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); 
            }
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
            do
            {
                Console.WriteLine(x);
            } while (x > 0);
            foreach(var num1 in myArray)
            {
                Console.WriteLine(num1);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
          
            Console.ReadKey();
        }
    }
}
