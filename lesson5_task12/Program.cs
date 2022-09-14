// Создание калькулятора
// Попросите пользователя ввести два числа, а также арифметическое действие (+, -, *, /). 
// В зависимости от символа, который будет введен, выполните математические действия над числами, 
// которые ввел пользователь.
// Для проверки данных используйте оператор switch case.

using System;

namespace lesson5_task12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Задайте действие:");
            char action = Convert.ToChar(Console.ReadLine());
    
            switch (action) 
                {case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Деление на ноль запрещено");
                    else
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Некорректное действие");
                    break;
                }
                
                
        }
    }
}
