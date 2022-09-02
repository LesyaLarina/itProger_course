// Ввод данных с клавиатуры
// Попросите пользователя ввести три слова через пробел. 
// Если пользователь введет менее трех слов, то выполните получение данных повторно. 
// Просите пользователя ввести данные до тех пор, пока не будет введено как минимум три слова через пробел.

using System;

namespace lessons3_5_task9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите три слова через пробел");
            string text = Console.ReadLine();
            string[] textarray = text.Split(' ');
            while (textarray.Length < 3)
            {
                Console.WriteLine("Попробуйте еще раз");
                text = Console.ReadLine();
                textarray = text.Split(' ');
            }
           
        }
    }
}
