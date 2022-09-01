// Остаток при деление
// Попросите пользователя ввести два числа. 
// Выполните операцию остаток от деления и выведите результат в консоль.

using System;

namespace lessons3_5_task6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Остаток от деления равен {num1%num2}");
        }
    }
}
