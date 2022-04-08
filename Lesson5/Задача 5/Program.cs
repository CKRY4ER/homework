using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lesson5
{
    /// <summary>
    /// Класс, описывающий задачу
    /// </summary>
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo() { }
        public ToDo(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            string s;
            s = IsDone ? "[x] " : "[ ] ";
            s += $"{Title};";
            return s;
        }
    }
    /// <summary>
    /// Отдельный класс для сериализации
    /// </summary>
    public class ListSerializer
    {
        private XmlSerializer serializer;
        public ListSerializer(Type type)
        {
            serializer = new XmlSerializer(type);
        }
        public void Serialize<T>(List<T> listObj)
        {
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, listObj);
            string xml = stringWriter.ToString();
            File.WriteAllText("tasks.xml", xml);
        }
        public List<T> Deserialize<T>()
        {
            List<T> listObj;
            string xmlText = File.ReadAllText("tasks.xml");
            StringReader stringReader = new StringReader(xmlText);
            listObj = serializer.Deserialize(stringReader) as List<T>;
            return listObj;
        }
    }
    class Program
    {
        /// <summary>
        /// Меню выбора действия
        /// </summary>
        /// <returns></returns>
        static string Menu()
        {
            string key;
            Console.WriteLine("1 - Список задач;\n2 - Добавить задачу;\n3 - Удалить задачу\n4 - Выполнить задачу;" +
                "\n5 - Сериализовать список задач в формате XML;\n0 - Выход из программы;");
            Console.Write("Выберите действие: ");
            key = Console.ReadLine();
            return key;
        }
        /// <summary>
        /// Создание новой задачи
        /// </summary>
        static void CreateNewTask(List<ToDo> listTask)
        {
            Console.Clear();
            ToDo newTask = new ToDo();
            Console.Write("Введите постановку новой задачи: ");
            newTask.Title = Console.ReadLine();
            listTask.Add(newTask);
            Console.Clear();
        }
        /// <summary>
        /// Выводит на экран все задачи
        /// </summary>
        static void ListTask(List<ToDo> listTask)
        {
            Console.Clear();
            Console.WriteLine("Список всех задач:");
            for(int i= 0; i < listTask.Count; i++)
            {
                Console.WriteLine($"{i+1} - {listTask[i]}");
            }
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Устанавливает статус задаче
        /// </summary>
        /// <param name="listTask"></param>
        static void SetIsDoneTask(List<ToDo> listTask)
        {
            Console.Clear();
            int i;
            Console.Write("Введите номер задачи: ");
            i = int.Parse(Console.ReadLine());
            try
            {
                listTask[i - 1].IsDone = true;
                Console.WriteLine($"Задача под номером {i} выполнена.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Задачи с данным номером нет в списке задач!");
            }
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        /// <param name="listTask"></param>
        static void DeleteTask(List<ToDo> listTask)
        {
            Console.Clear();
            int i;
            Console.Write("Введите номер задачи для удаления: ");
            i = int.Parse(Console.ReadLine());
            try
            {
                listTask.RemoveAt(i - 1);
                Console.WriteLine($"Задача под номером {i} удалена.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Задачи с данным номером нет в списке задач!");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            List<ToDo> taskList;
            ListSerializer listSerializer = new ListSerializer(typeof(List<ToDo>));
            if (File.Exists("tasks.xml"))
            {
                taskList = listSerializer.Deserialize<ToDo>();
                Console.WriteLine("Список задач загружен!");
                Console.ReadKey();
                Console.Clear();
            }
            else
                taskList = new List<ToDo>();
            string s;
            while ((s = Menu())!= "0")
            {
                Console.Clear();
                switch (s)
                {
                    case ("1"):
                        ListTask(taskList);
                        break;
                    case ("2"):
                        CreateNewTask(taskList);
                        break;
                    case ("3"):
                        DeleteTask(taskList);
                        break;
                    case ("4"):
                        SetIsDoneTask(taskList);
                        break;
                    case ("5"):
                        listSerializer.Serialize<ToDo>(taskList);
                        break;
                    case ("0"):
                        break;
                    default:
                        Console.WriteLine("Не верный ввод!");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
