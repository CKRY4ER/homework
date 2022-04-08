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
            Console.Write("Введите путь: ");
            string dir = Console.ReadLine();
            if (!Directory.Exists(dir))
            {
                Console.WriteLine("Данной дириектории не существует");
                Console.ReadKey();
                return;
            }
            string[] allFileInDir = Directory.GetFileSystemEntries(dir);
            File.WriteAllLines("dir.txt", allFileInDir);
            Console.WriteLine("Успешно записанно в файл!");
            Console.ReadKey();
        }
    }
}
