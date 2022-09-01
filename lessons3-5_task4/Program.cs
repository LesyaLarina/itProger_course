// Простой калькулятор
// Пользователь вводи два числа, после чего выводится меню:
// 1. Добавить
// 2. Отнять
// 0. Ничего
// В зависимости от того какую цифру введет пользователь, вы применяете подходящее действие.

using System;

namespace lessons3_5_task4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Добавить");
            Console.WriteLine("2. Отнять");
            Console.WriteLine("0. Ничего");
            byte operation = Convert.ToByte(Console.ReadLine());
            if (operation == 1) Console.WriteLine($"Сумма чисел равна {num1+num2}");
            else if (operation == 2) Console.WriteLine($"Разность чисел равна {num1-num2}");
            else if (operation == 0) Console.WriteLine($"Вы ввели {num1} и {num2}");
            else Console.WriteLine($"Некорректный оператор");
                
        

        }
    }
}
