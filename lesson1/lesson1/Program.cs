using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Guid a;
            a = Guid.NewGuid();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
