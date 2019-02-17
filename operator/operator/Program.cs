using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            ++x; // reps 1+10
            x++; // reps 10+1
            int y = ++x; //operator precedence y=13 and x = 13 here
            int z = x++; //z =13 here and x will be 14
            Console.WriteLine("value of x =" + x);
            Console.WriteLine("value of y =" + y);
            Console.WriteLine("value of z =" + z);
            Console.Read();
            //AND && || OR ^




        }
    }
}
