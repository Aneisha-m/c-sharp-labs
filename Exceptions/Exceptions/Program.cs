using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExceptionEx.myDivideMethod(6, 0);
            Console.WriteLine("After The Exception");
            Console.Read();
        }
    }

    class MyExceptionEx
    {
        public static void myDivideMethod(int num1, int num2)
        {
            try {
                Console.WriteLine(num1 / num2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }
    }
    //using
    class UsingKeyword
    {
        public void usingTheUsing()
        {
            using (var filestream = new filestream(@"c:\file.txt", FileMode.Create))
            {

            }
        }
    }
}
