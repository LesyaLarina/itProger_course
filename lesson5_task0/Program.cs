// Создайте программу для ввода в консоль двух произвольных чисел. При помощи тернарного оператора 
// сформулируйте ответ программы: либо деление полученных чисел, либо вывод 1.
// Подсказка: для конвертации в тип данных float используйте ToSingle.

using System;

namespace lesson5_task0
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 числа:");
            float num1 = Convert.ToSingle(Console.ReadLine ());
            float num2 = Convert.ToSingle(Console.ReadLine ());
            float res = num2 !=0 ? num1/num2 : 1;
            Console.WriteLine(res);
        }
    }
}
