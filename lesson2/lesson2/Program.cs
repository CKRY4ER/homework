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
            int maxTemp;
            int minTemp;
            float averageTemp;
            Console.Write("Введите максимальную температуру за сегодняшний день: ");
            maxTemp = int.Parse(Console.ReadLine());
            Console.Write("Введите минимальную температуру за сегодняшний день: ");
            minTemp = int.Parse(Console.ReadLine());
            averageTemp = (float)(maxTemp + minTemp) / 2;
            Console.WriteLine($"Средняя температура за день: {averageTemp: 0.00}");
            if ((DateTime.Now.Month == 12 || DateTime.Now.Month == 1 || DateTime.Now.Month == 3) && averageTemp > 0)
            {
                Console.WriteLine("Зима оказалась дождливой");
            }
            Console.ReadLine();
        }
    }
}
