using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            FillList(numbers);
            Console.WriteLine("Исходный список:");
            PrintList(numbers);

            RemoveNumbersInRange(numbers, 25, 50);
            Console.WriteLine("\nСписок после удаления чисел от 25 до 50:");
            PrintList(numbers);
            Console.ReadKey();
        }

        static void FillList(List<int> numbers)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(rand.Next(0, 101));
            }
        }

        static void PrintList(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void RemoveNumbersInRange(List<int> numbers, int min, int max)
        {
            numbers.RemoveAll(n => n > min && n < max);
        }
    }
}
