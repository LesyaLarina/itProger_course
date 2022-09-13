// Четные числа
// Из двух чисел с разной четностью вывести на экран четное число. a, b - данные числа.
// Если оба числа четные выведите - "Оба числа четные". Если оба числа не четные выведите - 
// "Нет четных чисел".
// Числа необходимо получить от пользователя с клавиатуры.

using System;

namespace lesson5_task9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0)
                Console.WriteLine("Оба числа четные");
            else if (a % 2 != 0 && b % 2 != 0)
                Console.WriteLine("Нет четных чисел");
            else if (a % 2 != 0 && b % 2 == 0)
                Console.WriteLine($"{b} четное");
            else 
                Console.WriteLine($"{a} четное");
        }
    }
}
