using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>();
            while (true)
            {
                Console.Write("Введите число (или пустую строку для завершения): ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (numbers.Add(number))
                    {
                        Console.WriteLine("Число успешно сохранено.");
                    }
                    else
                    {
                        Console.WriteLine("Число уже вводилось ранее.");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
        }
    }
}
