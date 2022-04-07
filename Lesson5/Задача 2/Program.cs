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
            string dateTime = DateTime.Now.ToString();
            File.WriteAllText("startup.txt", dateTime);
            Console.ReadKey();
        }
    }
}
