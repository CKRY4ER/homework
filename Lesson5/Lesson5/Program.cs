using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите названия файла, куда хотите сохранить текст: ");
            string fileName = Console.ReadLine();
            File.WriteAllText(fileName + ".txt", text);
            Console.WriteLine("Фаил успешно сохранен.");
            Console.ReadKey();

        }
    }
}
