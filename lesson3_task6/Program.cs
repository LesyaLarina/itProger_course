// 6.  Нахождение числа
// Создайте программу, которая будет принимать число (n), введенное пользователем, и выдавать результат 
//в виде (n + n * 2).
// Пример:
// // Вводим 23
// // Получаем: 2346

using System;

namespace lesson3_task6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num}{num*2}");
        }
    }
}
