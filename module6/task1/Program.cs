using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {

        const string FilePath = "data.txt";

        static void Main()
        {
            while (true) 
            {
                Console.WriteLine("Введите 1, чтобы вывести данные на экран.");
                Console.WriteLine("Введите 2, чтобы добавить нового сотрудника.");
                Console.WriteLine("Введите любую другую клавишу, чтобы выйти.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    DisplayEmployees();
                } 
                else if (choice == "2") 
                {
                    AddEmployee();
                } 
                else
                {
                    Console.WriteLine("Выход.");
                    break;
                }
                    
            }
        }

        static void DisplayEmployees()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                Console.WriteLine($"ID: {fields[0]}");
                Console.WriteLine($"Дата и время добавления: {fields[1]}");
                Console.WriteLine($"Ф. И. О.: {fields[2]}");
                Console.WriteLine($"Возраст: {fields[3]}");
                Console.WriteLine($"Рост: {fields[4]}");
                Console.WriteLine($"Дата рождения: {fields[5]}");
                Console.WriteLine($"Место рождения: {fields[6]}\n");
            }
        }

        static void AddEmployee()
        {
            int id = GetNextId();
            string dateAdded = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            Console.Write("Введите Ф. И. О.: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            string birthDate = Console.ReadLine();

            Console.Write("Введите место рождения: ");
            string birthPlace = Console.ReadLine();

            string record = $"{id}#{dateAdded}#{name}#{age}#{height}#{birthDate}#{birthPlace}";

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine(record);
            }

            Console.WriteLine("Запись добавлена.\n");
        }

        static int GetNextId()
        {
            if (!File.Exists(FilePath))
            {
                return 1;
            }

            int lastIndex = File.ReadLines(FilePath).ToArray().Length;

            return lastIndex + 1;
        }
    }
}
