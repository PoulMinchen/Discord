using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Calc(Operations.Add, 3, 4);

            Console.WriteLine(k);
            Console.ReadLine();

        }

        public static  int Calc(Operations op,int x,int y)
        {
            int res = 0 ;
            switch (op)
            {
                case Operations.Add:
                    res= x + y;
                    break;
                case Operations.Devide:
                    res= x / y;
                    break;
                case Operations.Multiply:
                    res= x * y;
                    break;
                case Operations.Substraction:
                    res= x - y;
                    break;

            }
            return res;


        }

        public enum Operations
        {
            Add,
            Substraction,
            Multiply,
            Devide

        }
    }
}
