using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine($"Число {numb} четное");
            }
            else
            {
                Console.WriteLine($"Число {numb} не четное");
            }
            Console.ReadLine();
        }
    }
}
