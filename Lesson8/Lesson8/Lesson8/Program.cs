using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);
            //Проверка, есть ли инфо о пользователе
            if (Properties.Settings.Default.UserName == "")
            {
                Console.Write("Введите имя пользователя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите свой возраст: ");
                Properties.Settings.Default.Age = int.Parse(Console.ReadLine());
                Console.Write("Введите свой род деятельности: ");
                Properties.Settings.Default.TypeOfActivity = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Имя пользователя: {Properties.Settings.Default.UserName}\n" +
                    $"Возраст: {Properties.Settings.Default.Age}\n" +
                    $"Род деятельности: {Properties.Settings.Default.TypeOfActivity}");
            }
            Console.ReadKey(true);
        }
    }
}
