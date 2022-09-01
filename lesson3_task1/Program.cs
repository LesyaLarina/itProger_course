// 1.  Обмен переменными
// Создайте программу, что будет запрашивать два числа у пользователя. 
// Полученные данные поместите в переменные. Поменяйте местами значения в переменных.

using System;

namespace lesson3_task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два числа:");
            short num1 = Convert.ToInt16(Console.ReadLine());
            short num2 = Convert.ToInt16(Console.ReadLine());
            short temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Если поменять местами, будет {num1} и {num2}");
        }
    }
}
