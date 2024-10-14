using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас на руках карт?");
            int cardCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < cardCount; i++)
            {
                Console.WriteLine("Введите номинал карты (2-10, J, Q, K, T):");
                string card = Console.ReadLine().ToUpper();

                switch (card)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(card);
                        break;
                }
            }

            Console.WriteLine($"Сумма карт на руках: {sum}");
            Console.ReadKey();
        }
    }
}
