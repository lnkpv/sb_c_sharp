using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                int i = 2;
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Число простое.");
            }
            else
            {
                Console.WriteLine("Число не является простым.");
            }
            Console.ReadKey();
        }
    }
}
