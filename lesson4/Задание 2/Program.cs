using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        public static int Counting(string s)
        {
            string[] number = s.Split(' ');
            int count=0;
            for (int i=0; i < number.Length; i++)
            {
                try
                {
                    count += int.Parse(number[i]);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Возможно вы ввели не целое число или символ.");
                    Console.ReadKey();
                    break;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа через пробел: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Сумма всех чисел равна: {Counting(s)}");
            Console.ReadKey();
        }
    }
}
