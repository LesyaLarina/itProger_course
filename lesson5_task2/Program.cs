// Проверка переменных
// Проверить две переменные на их четность. Если обе четные, то выдается значение true, иначе false.
// Важно: проверку необходимо выполнить при помощи сокращенной формы if else.

using System;

namespace lesson5_task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 переменные");
            short num1 = Convert.ToInt16(Console.ReadLine());
            short num2 = Convert.ToInt16(Console.ReadLine());
            bool parity = num1%2 == 0 && num2%2 == 0 ? true : false;
            Console.WriteLine(parity);
        }
    }
}
