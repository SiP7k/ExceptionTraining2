using System;

namespace HW2
{
    class InputReader
    {
        public delegate void ReadDelegate(string input);
        public event ReadDelegate SortEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("1) - Сортировка А-Я\n2) - Сортировка Я-А");
            string userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2")
            {
                throw new InputException("Неправильный ввод данных");
            }

            ReadCompleted(userInput);
        }
        protected virtual void ReadCompleted(string str)
        {
            SortEvent?.Invoke(str);
        }
    }
}
