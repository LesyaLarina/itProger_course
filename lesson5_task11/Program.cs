// Оператор Switch
// Создайте переменную со значением 11.
// При помощи оператора switch case проверяйте переменную:
// если она равна 10 - выведите в консоль «Number is 10».
// если она равна 15 - выведите в консоль «Number is 15».
// иначе выведите в консоль «Something else».

using System;

namespace lesson5_task11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите переменную:"); // Сознательно усложним
            byte num = Convert.ToByte(Console.ReadLine());
            // Вариант с новым синтаксисом
            // string res = num switch
            // {
            //     10 => "Number is 10",
            //     15 => "Number is 15",
            //     _ => "Something else"
            // };
            // Console.WriteLine(res);
            switch (num) 
            {
                case 10: 
                    Console.WriteLine("Number is 10");
                    break;
                case 15: 
                    Console.WriteLine("Number is 15");
                    break;
                default: 
                    Console.WriteLine("Something else");
                    break;
            }

        }
    }
}
