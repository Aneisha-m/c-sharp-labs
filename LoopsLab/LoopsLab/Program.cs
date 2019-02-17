using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class LoopLab
    {
        public int Cum()
        {
            int total = 0;
            int j;
            for(j = 0; j < 100; j++)
            {
                total = total + j;
            }
            return total;
        }

        public int Cum()
        {
            int tot = 0;
            int i;
            for(int i = 0; i <=25)
        }

    }

    //Breaking out of Loops
    class BreakingOutOfLoops
    {
        //break
        //goto
        //return
        //continue
        //throw
        int myValueReturned = 0;
        int myMethod()
        {
            return 3;
       
        }
        void method2()
        {
            myValueReturned = myMethod();
        }
        void methodContinue()
        {
            for (int k = 0; k < 10; k++)
            {
                if(k % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
