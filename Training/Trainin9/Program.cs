using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin9
{
    class Program
    {
        static void Main(string[] args)
        {
            Count c1 = new Count { Number = 10 };
            Count c2 = new Count { Number = 20 };
            int a = c1 + c2;
            int m = c1 * c2;
            int d = c1 / c2;
            bool sr = c1 < c2;
            Console.WriteLine($"{a}\n{m}\n{d}\n{sr}");
            Console.ReadLine();

        }
    }

    class Count
    {
        public int Number { get; set; }

        public static int operator+(Count a,Count b)
        {
            return a.Number + b.Number;
        }

        public static int operator*(Count a,Count b)
        {
            return a.Number * b.Number;
        }

        public static int operator/(Count a,Count b)
        {
            return a.Number / b.Number;
        }
        public static bool operator>(Count a,Count b)
        {
            if (a.Number > b.Number)
                return true;
            else
            {
                return false;
            }
                 
        }
        public static bool operator<(Count a,Count b)
        {
            if (a.Number < b.Number)
                return true;
            else
            {
                return false;
            }
        }

    }
}
