using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] telephoneDirectory = { {"Евгений Нечаев", "89325459109"},
                { "Адамович Роман","89432341242"},
                {"Рускановский Руслан","87642412451"},
                {"Захаров Андрей","8932617524"},
                {"Ионов Алексей", "85498156429"}
            };
            Console.WriteLine("Вывод справочикка: ");
            for (int i = 0; i < telephoneDirectory.GetLength(0); i++)
            { 
                for (int j = 0; j < 2; j++)
                {
                    switch (j)
                    {
                        case (0):
                            Console.Write($"ФИ: {telephoneDirectory[i, j]} ");
                            break;
                        case (1):
                            Console.Write($"Телефон: {telephoneDirectory[i, j]}");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
