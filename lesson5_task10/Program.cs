
// Большая проверка
// Создайте переменную А со значением 34.
// Создайте проверку if else, которая выведен на экран слово 
// "Working" в случае если переменная А будет меньше за 50 и не равна 37, но при этом не меньше или равна 32.
// Допишите в само условие ИЛИ проверку: если число А будет равным 0 или 15, то условие также 
// будет выполняться.

using System;

namespace lesson5_task10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Немного усложним и введем число с клавиатуры:");
            byte A = Convert.ToByte(Console.ReadLine());
            if ((A < 50 && A != 37 && A > 32) || (A == 0 || A == 15))
                Console.WriteLine("Working");
            else
                System.Console.WriteLine("Not working");
        }
    }
}
