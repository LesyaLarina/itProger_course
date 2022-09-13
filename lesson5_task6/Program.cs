// Сравнение строк
// Напишите программу, которая будет сравнивать количество символов в двух произвольных строках, 
// введенных пользователем.
// Пример:
// // Первая строка: Обычная строка
// // Вторая строка: Уже другая строка
// // результат: Обычная строка меньше чем Уже другая строка

using System;

namespace lesson5_task6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первая строка:");
            string text1 = Console.ReadLine();
            Console.WriteLine("Вторая строка:");
            string text2 = Console.ReadLine();
            if (text1.Length == text2.Length) 
                Console.WriteLine("Строки одной длины");
            else if (text1.Length > text2.Length) 
                Console.WriteLine("Первая строка длиннее");
            else 
                Console.WriteLine("Вторая строка длиннее");
        }
    }
}
