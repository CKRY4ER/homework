using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введито строку: ");
            string str = Console.ReadLine();
            Console.Write($"Реверс введенной строки: ");
            for(int i = str.Length-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadLine();
        }
    }
}
