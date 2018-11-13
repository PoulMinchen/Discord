using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin4
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }




        static void Main(string[] args)
        {
            int fac = Factorial(5);
            Console.WriteLine(fac);

            int Fib = Fibonacci(3);
            Console.WriteLine(Fib);
            Console.ReadLine();


        }


    }

}
