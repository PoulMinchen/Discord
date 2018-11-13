using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mas = new int[7];
            Console.WriteLine("Введите семь чисел");
            for(int i=0;i<7;i++)
            {
                Console.Write($"{i}: ");
                mas[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i+1; j < mas.Length; j++)
                {
                    if(mas[i]>mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;

                    }
                }
            }
            Console.WriteLine();
            foreach(int n in mas)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();

        }
    }
}
