// 9.  Преобразование данных
// Получите от пользователя данные и запишите их в переменные с типами данных:
// short
// ulong
// char
// double. 

using System;

namespace lesson3_task9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число от -32768 до 32767:");
            short num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите очень большое положительное число:");
            ulong num2 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите символ:");
            char symb = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите большое число со знаками после запятой:");
            double num3 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
