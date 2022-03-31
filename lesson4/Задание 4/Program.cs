using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static int FibRec(int p1, int p2, int n)
        {
            return n == 0 ? p1 : FibRec(p2, p1 + p2, n - 1);
        }
        static int Fib(int n) { return FibRec(0, 1, n); }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число Фибоначи от числа {i}: {Fib(i)}");
            Console.ReadLine();
        }
    }
}
