// 10.  Операции над переменной
// Создайте переменную со значением -5. 
// Выполните над ней операции:
// умножьте её на 7;
// выполните декременацию (уменьшение на один).

using System;

namespace lesson3_task10
{
    class Program
    {
        static void Main()
        {
            sbyte num = -5;
            num *= 7;
            --num; 
            Console.WriteLine(num);
        }
    }
}
