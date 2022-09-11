using System;
using System.Collections.Generic;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            InputReader ir = new InputReader();
            ir.SortEvent += Sort;

            try
            {
                ir.Read();
            }
            catch (InputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
        public static void Sort(string userInput)
        {
            var lastNames = CreateList();
            lastNames.Sort();

            switch (userInput)
            {
                case "1":
                    {
                        Console.WriteLine("Список отсортирован А-Я");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Список отсортирован Я-А");
                        lastNames.Reverse();
                        break;
                    }
            }
            ShowList(lastNames);
        }
        private static List<string> CreateList()
        {
            List<string> lastNames = new List<string>() { "Alcash", "Graponov", "Ivanov", "Smuslov", "Sergeev" };
            return lastNames;
        }
        private static void ShowList(List<string> lastNames)
        {
            Console.Clear();
            Console.WriteLine("\nСписок фамилий:");

            foreach (var lastName in lastNames)
            {
                Console.WriteLine(lastName);
            }
        }
    }
}
