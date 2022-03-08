using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Prodyct
    {
        public decimal Price
        {
            set;
            get;
        }
        public string NameProdyct
        {
            set;
            get;
        }
        public Prodyct(decimal price, string name)
        {
            Price = price;
            NameProdyct = name;
        }
        public override string ToString()
        {
            string s = $"{NameProdyct}, {Price} рублей";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Prodyct> prodyctList = new List<Prodyct>() 
            {   new Prodyct(30,"Хлеб"), 
                new Prodyct(60, "Молоко"), 
                new Prodyct(130, "Курица"),
                new Prodyct(74, "Макароны")
            };
            Console.WriteLine("Выберите магазин где хотите купить товары:\n1. Пятерочка\n2. Магнит");
            string market;
            int key=int.Parse(Console.ReadLine());
            switch (key)
            {
                case (1):
                    market = "Пятерочка";
                    break;
                case (2):
                    market = "Магнит";
                    break;
                default:
                    market = "Магнит";
                    break;
            }
            key = 2;
            Console.Clear();
            List<Prodyct> purProducts = new List<Prodyct>();
            Console.WriteLine($"Выберите товар в магазине {market}");
            while (key != 0)
            {
                Console.WriteLine($"Выберите продукт:\n1. {prodyctList[0].ToString()}\n2. {prodyctList[1].ToString()}\n" +
                    $"3. {prodyctList[2].ToString()}\n4. {prodyctList[3].ToString()}\nВведите номер продукта или 0, чтобы закончить покупки: ");
                key = int.Parse(Console.ReadLine());
                if (key != 0)
                {
                    switch (key)
                    {
                        case (1):
                            purProducts.Add(prodyctList[0]);
                            break;
                        case (2):
                            purProducts.Add(prodyctList[1]);
                            break;
                        case (3):
                            purProducts.Add(prodyctList[2]);
                            break;
                        case (4):
                            purProducts.Add(prodyctList[3]);
                            break;
                        default:
                            Console.WriteLine("Введен не верный номер продукта. Нажмите Enter для продолжения");
                            Console.ReadLine();
                            break;
                    }
                }
                Console.Clear();
            }
            if (purProducts.Count == 0)
            {
                Console.WriteLine("Вы вышли из магазина ничего не купив");
            }
            else
            {
                decimal finalPrice=0;
                Console.WriteLine($"Ваш чек:\nСпасибо за покупку в магазине {market}!\n" +
                    $"Список купленных товаров:");
                foreach (Prodyct pr in prodyctList)
                {
                    Console.WriteLine($"{pr.ToString()}");
                    finalPrice += pr.Price;
                }
                Console.WriteLine($"Итоговая цена: {finalPrice} руб.");
            }
            Console.ReadLine();
        }
    }
}
