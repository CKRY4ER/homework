using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        private static bool Menu()
        {
            Console.Write("1 - Ввести новое ФИО\n2 - Вывести все введенные ФИО\nВведите число: ");
            short i = short.Parse(Console.ReadLine());
            Console.Clear();
            return i == 1 ? true : false;
        }
        public static string GetFullName(string lastName, string firsName, string patronymic)
        {
            string s = lastName + " " + firsName + " " + patronymic;
            return s;
        }
        static void Main(string[] args)
        {
            string lastName;
            string firstName;
            string patronymic;
            List<string> listPerson = new List<string>();
            while (Menu())
            {
                Console.Write("Введите Фамилию: ");
                lastName = Console.ReadLine();
                Console.Write("Введите Имя: ");
                firstName = Console.ReadLine();
                Console.Write("Введите Отчество: ");
                patronymic = Console.ReadLine();
                listPerson.Add(GetFullName(lastName, firstName, patronymic));
                Console.Clear();
            }
            foreach (string s in listPerson)
            {
                Console.WriteLine($"ФИО: {s}");
            }
            Console.ReadLine();
        }
    }
}
