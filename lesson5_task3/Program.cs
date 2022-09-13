// Обычная бухгалтерия
// Создайте программу, которая будет рассчитывать сальдо торгового баланса. В случае положительного сальдо 
// (превышение экспорта над импортом) просчитывать прибыль, а в случае отрицательного сальдо 
// (превышение импорта над экспортом) рассчитать потери.
// Например:
// // Переменные: потери - 750 и прибыль - 345
// // Программа выдаст результат:
// "Ваши убытки составили: 405"
// // В случае прибыли будет подсчитана прибыль

using System;

namespace lesson5_task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Выручка: ");
            int profit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Потери: ");
            int loss = Convert.ToInt32(Console.ReadLine());
            if (profit > loss) 
                Console.WriteLine($"Прибыль: {profit - loss}");
            else if (profit < loss)
                Console.WriteLine($"Убыток: {loss - profit}");
            else Console.WriteLine("Вышли в ноль");

        }
    }
}
