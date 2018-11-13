using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] mas = new int[10];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 256);
            }
            Display(mas);

            int n = mas.Length;
            int cent = n / 2;
            int temp;

            Console.WriteLine();
            for (int i = 0; i < cent; i++)
            {
                temp = mas[i];
                mas[i] = mas[n - i - 1];
                mas[n - i - 1] = temp;

            }
            Display(mas);

            Console.ReadLine();

        }
        public static void Display(params int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
