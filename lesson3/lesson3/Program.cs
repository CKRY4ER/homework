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
            Console.Write("Введите размернотсь n квадратичной матрицы (nXn): ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] matrix = new int[n, n];
            Console.WriteLine("Созданная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Элементы, которые находятся на главной диагонали: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
