// Депозитный калькулятор
// Создайте программу «Депозитный калькулятор», которая будет рассчитывать ежегодную и итоговую сумму 
//вклада с учетом процентной ставки банка.
// Пример:
// Сумма: 1250
// Годы: 5
// Процент: 12
// 1 год - 1400
// 2 год - 1568
// 3 год - 1756
// 4 год - 1966
// После 4 лет сумма будет - 1966

using System;

namespace lessons3_5_task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Сумма: ");
            int summ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Годы: ");
            byte years = Convert.ToByte(Console.ReadLine());
            Console.Write("Процент: ");
            byte rate = Convert.ToByte(Console.ReadLine());
            for (byte i = 1; i < years; i++)
            {
                Console.Write($"{i} год ");
                summ = summ+summ*rate/100;
                Console.WriteLine(summ);
                }
            Console.WriteLine($"После {years-1} лет сумма будет - {summ}");
        }
    }
}
