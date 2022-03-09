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
            string[,] fight =
            {
                {"X","X","O","X","O","O","X","X","X","X" },
                {"O","O","O","X","O","O","O","O","O","O" },
                {"O","O","O","X","O","O","O","O","O","X"},
                {"O","O","O","X","O","O","O","O","O","X"},
                {"O","X","O","O","O","O","X","O","O","O"},
                {"O","X","O","O","O","O","O","O","O","O"},
                {"O","X","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","X","X","O","O","X","O","O" },
                {"X","O","O","O","O","O","O","X","O","O"}
            };
            Console.WriteLine("Игральное поле:");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(fight[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
