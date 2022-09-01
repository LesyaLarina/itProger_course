// Поле из символов
// Напишите программу, которая будет рисовать поле из символа, который введет пользователь. 
// Пример:
// // Пользователь вводит 4
// // В итоге выводиться следующее
// 4444
// 4  4
// 4  4
// 4444

using System;

namespace lessons3_5_task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ:");
            char symb = Convert.ToChar(Console.Read());
            Console.WriteLine($"{symb}{symb}{symb}{symb}");
            Console.WriteLine($"{symb}  {symb}");
            Console.WriteLine($"{symb}  {symb}");
            Console.WriteLine($"{symb}{symb}{symb}{symb}");
        }
    }
}
