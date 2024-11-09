using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string inputText = Console.ReadLine();

            string[] words = SplitText(inputText);

            DisplayWords(words);
            Console.ReadKey();
        }

        static string[] SplitText(string text)
        {
            char[] separator = new char[] { ' ' };
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        static void DisplayWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
