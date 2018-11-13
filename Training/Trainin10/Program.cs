using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int s = r.Next(1, 32);
            int n = r.Next(65535);
            Console.WriteLine(s);
            Console.WriteLine("{0:X}",n);
            Operation on = new Operation(s, n);
            int n2=on.operat();
            Console.WriteLine("{0:X}", n2);
            Console.ReadLine();
        }


    }

    class Operation
    {
        int number;
        int DefaulGr;

        public Operation(int n, int n2)
        {
            this.number = n;
            this.DefaulGr = n2;

        }

        public int operat()
        {
            int k1;
            int Fpt;
            int Lpt;

            k1 = (int)Math.Pow(2, DefaulGr);
            k1 -= 1;
            Fpt = number & k1;
            k1 = ~k1;
            Lpt = number & k1;
            Fpt = Fpt << DefaulGr;
            Lpt = Lpt >> DefaulGr;
            Fpt = Fpt | Lpt;
            return Fpt;


        }



    }


}
