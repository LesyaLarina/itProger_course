// 4.  Работа с переменными
// Попросите пользователя ввести имя, а также возраст.
// Выведите полученные данные в формате: «Привет, ИМЯ! Тебе уже ВОЗРАСТ».

using System;

namespace lesson3_task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите свое имя:");
            string username = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            byte userage = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Привет, {username}! Тебе уже {userage}");
        }
    }
}
