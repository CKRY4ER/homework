using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        public enum Season
        {
            Winter, Spring, Summer, Autumn
        }
        public static Season Month(int a)
        {
            Season season = new Season();
            if (a >= 1 && a <= 3)
                season = Season.Winter;
            else if (a >= 4 && a <= 6)
                season = Season.Spring;
            else if (a >= 7 && a <= 9)
                season = Season.Summer;
            else if (a >= 10 && a <= 12)
                season = Season.Autumn;
            return season;
        }
        public static string NameSeasonOfYear(Season season)
        {
            string s="";
            switch (season)
            {
                case (Season.Winter):
                    s = "Зима";
                    break;
                case (Season.Spring):
                    s = "Весна";
                    break;
                case (Season.Summer):
                    s = "Лето";
                    break;
                case (Season.Autumn):
                    s = "Осень";
                    break;
            }
            return $"Название времени года: {s}";
        }
        static void Main(string[] args)
        {
            int i=0;
            Console.Write("Введите число от 1 до 12: ");
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Введено не целое чилсо или символ!");
                Console.ReadLine();
                return;
            }
            if (i > 12 && i < 1)
            {
                Console.WriteLine("Необходимо вводить число из промежутка 1 до 12!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(NameSeasonOfYear(Month(i)));
            Console.ReadLine();
        }
    }
}
