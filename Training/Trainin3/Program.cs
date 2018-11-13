﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write(mas[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
