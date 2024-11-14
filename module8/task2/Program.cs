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
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            AddContacts(phoneBook);

            Console.WriteLine("\nПоиск владельца по номеру телефона:");
            FindOwnerByPhone(phoneBook);

            Console.ReadKey();
        }

        static void AddContacts(Dictionary<string, string> phoneBook)
        {
            while (true)
            {
                Console.Write("Введите номер телефона (или оставьте пустым для завершения): ");
                string phone = Console.ReadLine();
                if (string.IsNullOrEmpty(phone))
                    break;

                Console.Write("Введите ФИО владельца: ");
                string name = Console.ReadLine();
                phoneBook[phone] = name;
            }
        }

        static void FindOwnerByPhone(Dictionary<string, string> phoneBook)
        {
            Console.Write("Введите номер телефона для поиска: ");
            string searchPhone = Console.ReadLine();
            if (phoneBook.TryGetValue(searchPhone, out string owner))
            {
                Console.WriteLine($"Владелец: {owner}");
            }
            else
            {
                Console.WriteLine("Владельца с таким номером нет.");
            }
        }
    }
}
