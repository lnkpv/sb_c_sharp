﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Число нечётное.");
            }
            Console.ReadKey();
        }
    }
}
