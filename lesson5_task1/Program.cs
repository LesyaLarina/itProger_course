// Небольшой калькулятор
// Создайте программу, которая будет принимать 3 значения от пользователя и 
// далее производить математическое действие (+, -, *, /). 
// Например:
// "Первое число: 2"
// "Операция: -"
// "Второе число: 3"
// 2 - 3 = -1
// При делении на ноль должна выдаваться ошибка.

using System;

namespace lesson5_task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое число: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Операция: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            if (operation == '+') Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            else if (operation == '-') Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            else if (operation == '*') Console.WriteLine($"{num1} * {num2} = {num1*num2}");
            else if (operation == '/') 
            {
                if (num2 == 0) Console.WriteLine("Ошибка: деление на 0");
                else Console.WriteLine($"{num1} / {num2} = {num1/num2}");
            }
            else Console.WriteLine("Некорректный оператор");
            
        } 
    }
}
