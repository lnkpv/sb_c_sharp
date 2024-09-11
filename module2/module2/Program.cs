using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            string fullName = "Иванов Иван Иванович";
            int age = 20;
            string email = "ivanov@test.com";
            double programmingScore = 88.5;
            double mathScore = 91.0;
            double physicsScore = 73.5;

            Console.WriteLine($"Информация о студенте: " +
                $"\nФИО: {fullName} " +
                $"\nВозраст: {age} " +
                $"\nEmail: {email} " +
                $"\nБаллы по программированию: {programmingScore} " +
                $"\nБаллы по математике: {mathScore} " +
                $"\nБаллы по физике: {physicsScore}");

            Console.ReadKey();

            // Задание 2.
            double totalScore = programmingScore + mathScore + physicsScore;
            double averageScore = totalScore / 3;

            // Для среднего значения решила вывести 4 знака после запятой
            Console.WriteLine($"\nРезультаты: " +
                $"\nСумма баллов по всем предметам: {totalScore} " +
                $"\nСредний балл: {averageScore:#.####}");

            Console.ReadKey();
        }
    }
}
