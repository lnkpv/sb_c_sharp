using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int length = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Введите число:");
                int number = int.Parse(Console.ReadLine());

                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Наименьшее число: {min}");
            Console.ReadKey();
        }
    }
}
