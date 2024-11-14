using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            XElement person = new XElement("Person",
                new XAttribute("name", name),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone)
                )
            );

            string fileName = "../../contact.xml";

            person.Save(fileName);
            Console.WriteLine("Контакт сохранен в файл contact.xml");
            Console.ReadKey();
        }
    }
}
