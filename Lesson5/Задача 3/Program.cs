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
            Console.Write("Введите кол-во чисел: ");
            int countNumbers;
            try
            {
                countNumbers = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Вводите только число!");
                Console.ReadLine();
                return;
            }
            byte[] numbers = new byte[countNumbers];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Введите числло от 0 дл 255: ");
                try
                {
                    numbers[i] = byte.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вводите тольско числа!");
                    Console.ReadLine();
                    return;
                }
                if (numbers[i]<0 && numbers[i] > 255)
                {
                    Console.WriteLine("Число не попадает в промежуток 255! Будет записанно число 0.");
                }
            }
            File.WriteAllBytes("numbers.bin", numbers);
            Console.WriteLine("Числа записанны в бинарный файл numbers.bin");
            Console.ReadLine();
        }
    }
}
