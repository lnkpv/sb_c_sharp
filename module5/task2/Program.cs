using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите предложение: ");
            string inputPhrase = Console.ReadLine();

            string reversedPhrase = ReverseWords(inputPhrase);
            Console.WriteLine("Результат:");
            Console.WriteLine(reversedPhrase);
            Console.ReadKey();
        }

        static string ReverseWords(string text)
        {
            string[] words = SplitText(text);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        static string[] SplitText(string text)
        {
            char[] separator = new char[] { ' ' };
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
