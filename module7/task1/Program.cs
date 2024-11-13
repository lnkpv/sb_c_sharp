using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    struct Worker
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
    }

    class Repository
    {
        private const string FilePath = "data.txt";


        public Worker[] GetAllWorkers()
        {
            if (!File.Exists(FilePath))
            {
                return new Worker[0];
            }

            var lines = File.ReadAllLines(FilePath);
            var workers = new List<Worker>();

            foreach (var line in lines)
            {
                var fields = line.Split('#');
                workers.Add(new Worker
                {
                    Id = int.Parse(fields[0]),
                    DateAdded = DateTime.Parse(fields[1]),
                    FIO = fields[2],
                    Age = int.Parse(fields[3]),
                    Height = int.Parse(fields[4]),
                    BirthDate = fields[5],
                    BirthPlace = fields[6]
                });
            }

            return workers.ToArray();
        }


        public Worker GetWorkerById(int id)
        {
            var workers = GetAllWorkers();
            return workers.FirstOrDefault(worker => worker.Id == id);
        }


        public void DeleteWorker(int id)
        {
            var workers = GetAllWorkers();
            var newWorkers = workers.Where(worker => worker.Id != id).ToArray();
            if (workers.Length == newWorkers.Length)
            {
                Console.WriteLine("Нет сотрудника с таким ID.\n");
            }
            else
            {
                Console.WriteLine("Запись удалена.\n");
            }
            SaveWorkers(newWorkers.ToList());
            
        }


        public void AddWorker(Worker worker)
        {
            var workers = GetAllWorkers().ToList();
            worker.Id = workers.Count > 0 ? workers.Max(w => w.Id) + 1 : 1;
            workers.Add(worker);
            SaveWorkers(workers);
        }


        private void SaveWorkers(List<Worker> workers)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (var worker in workers)
                {
                    writer.WriteLine($"{worker.Id}#{worker.DateAdded:dd.MM.yyyy HH:mm}#{worker.FIO}#{worker.Age}#{worker.Height}#{worker.BirthDate}#{worker.BirthPlace}");
                }
            }
        }


        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            var workers = GetAllWorkers();
            return workers.Where(w => w.DateAdded >= dateFrom && w.DateAdded <= dateTo).ToArray();
        }
    }

    internal class Program
    {
        const string FilePath = "data.txt";
        static Repository repository = new Repository();
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите 1, чтобы вывести данные на экран.");
                Console.WriteLine("Введите 2, чтобы вывести одного сотрудника по ID.");
                Console.WriteLine("Введите 3, чтобы добавить нового сотрудника.");
                Console.WriteLine("Введите 4, чтобы удалить сотрудника.");
                Console.WriteLine("Введите 5, чтобы загрузить записи по диапазону дат.");
                Console.WriteLine("Введите любую другую клавишу, чтобы выйти.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    DisplayEmployeesList(repository.GetAllWorkers());
                }
                else if (choice == "2")
                {
                    Console.Write("Введите ID сотрудника для просмотра: ");
                    int id = int.Parse(Console.ReadLine());
                    var worker = repository.GetWorkerById(id);
                    if (worker.Id == 0)
                    {
                        Console.WriteLine("Нет такого сотрудника\n");
                    }
                    else
                    {
                        DisplayEmployee(worker);
                    }
                    
                }
                else if (choice == "3")
                {
                    AddEmployee();
                }
                else if (choice == "4")
                {
                    Console.Write("Введите ID сотрудника для удаления: ");
                    int id = int.Parse(Console.ReadLine());

                    repository.DeleteWorker(id);
                }
                else if (choice == "5")
                {
                    Console.Write("Введите дату начала (дд.мм.гггг): ");
                    DateTime dateFrom = DateTime.Parse(Console.ReadLine());

                    Console.Write("Введите дату окончания (дд.мм.гггг): ");
                    DateTime dateTo = DateTime.Parse(Console.ReadLine());

                    var workers = repository.GetWorkersBetweenTwoDates(dateFrom, dateTo);
                    DisplayEmployeesList(workers);
                }
                else
                {
                    Console.WriteLine("Выход.");
                    break;
                }

            }
        }

        static void AddEmployee()
        {
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

            Worker worker = new Worker
            {
                DateAdded = DateTime.Now,
                FIO = name,
                Age = age,
                Height = height,
                BirthDate = birthDate,
                BirthPlace = birthPlace
            };

            repository.AddWorker(worker);
            Console.WriteLine("Запись добавлена.\n");
        }

        static void DisplayEmployeesList(Worker[] workers)
        {
            foreach (var worker in workers)
            {
                DisplayEmployee(worker);
            }

        }

        static void DisplayEmployee(Worker worker)
        {
            Console.WriteLine($"ID: {worker.Id}");
            Console.WriteLine($"Дата и время добавления: {worker.DateAdded}");
            Console.WriteLine($"Ф. И. О.: {worker.FIO}");
            Console.WriteLine($"Возраст: {worker.Age}");
            Console.WriteLine($"Рост: {worker.Height}");
            Console.WriteLine($"Дата рождения: {worker.BirthDate}");
            Console.WriteLine($"Место рождения: {worker.BirthPlace}\n");
        }

    }
}
