using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите максимальное число диапазона:");
            int maxRange = int.Parse(Console.ReadLine());
            int target = random.Next(0, maxRange + 1);

            while (true)
            {
                Console.WriteLine("Введите ваше предположение (или нажмите Enter, чтобы завершить игру):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Вы завершили игру. Загаданное число было: {target}");
                    break;
                }

                int guess = int.Parse(input);

                if (guess < target)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
