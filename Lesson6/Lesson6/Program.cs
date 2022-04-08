using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        public static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Выбрать процесс;\n2 - Вывести все процессы на экран;\n0 - Выход;");
            Console.Write("Введите число: ");
            return Console.ReadLine();
        }
        public static void OutAllProcesses(Process[] proc)
        {
            Console.WriteLine("Все процессы:");
            for (int i=0; i < proc.Length; i++)
            {
                Console.WriteLine($"Id:{proc[i].Id}      Name: {proc[i].ProcessName}");
            }
            Console.ReadKey();
        }
        public static string Menu2()
        {
            Console.WriteLine("По какому принципу выбрать процесс: \n1 - По Id\n2 - По имени");
            Console.Write("Введите число: ");
            return Console.ReadLine();
        }
        public static void FindeProcessById(Process[] proc, int id)
        {
            foreach (Process pr in proc)
            {
                if (pr.Id == id)
                {
                    pr.Kill();
                    Console.WriteLine("Процесс успешно завершен!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Процесса с данным id нет.");
            Console.ReadKey();
        }
        public static void FindeProcessByName(Process[] proc, string name)
        {
            bool isDelete = false;
            foreach (Process pr in proc)
            {
                if (pr.ProcessName==name)
                {
                    pr.Kill();
                    Console.WriteLine("Процесс успешно завершен!");
                    Console.ReadLine();
                    isDelete = true;
                }
            }
            if (!isDelete)
            {
                Console.WriteLine("Процесса с данным именем нет.");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            string key;
            while ((key = Menu()) != "0")
            {
                Console.Clear();
                Process[] processes = Process.GetProcesses();
                switch (key)
                {
                    case ("1"):
                        string s2=Menu2();
                        switch (s2)
                        {
                            case ("1"):
                                Console.Write("\nВведите Id процесса: ");
                                int i = int.Parse(Console.ReadLine());
                                FindeProcessById(processes, i);
                                break;
                            case ("2"):
                                Console.Write("\nВведите имя процесса: ");
                                string name = Console.ReadLine();
                                FindeProcessByName(processes, name);
                                break;
                        }
                        break;
                    case ("2"):
                        OutAllProcesses(processes);
                        break;
                    default:
                        Console.WriteLine("Не верный ввод!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
