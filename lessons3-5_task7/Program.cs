// Константы
// Создайте константу со значением 20.
// Получите второе число от пользователя и проведите математические операции над переменными:
// сложение;
// вычитание;
// умножение;
// деление.

using System;

namespace lessons3_5_task7
{
    class Program
    {
        static void Main()
        {
            const byte NUM1 = 20;
            Console.Write("Введите число: ");
            short num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Если сложить это число с константой, будет {NUM1+num2}");
            Console.WriteLine($"Если вычесть из этого числа константу, будет {num2-NUM1}");
            Console.WriteLine($"Если умножить это число на константу, будет {NUM1*num2}");
            Console.WriteLine($"Если разделить это число на константу, будет {num2/NUM1}, остаток от деления - {num2%NUM1}");
        }
    }
}
