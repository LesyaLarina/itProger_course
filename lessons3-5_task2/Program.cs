// Доменное имя
// Попросите пользователя ввести URL какого-либо сайта. После ввода данных выведите в консоль доменное имя полученного URL адреса.
// Пример:
// // Получил значение - itproger.com
// // в консоль будет выведено - com
// Подсказка: стоит использовать функцию split.

using System;

namespace lessons3_5_task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите URL сайта");
            string urlname = Console.ReadLine();
            string[] urldot = urlname.Split(new char[]{'.'});
            Console.WriteLine(urldot[urldot.Length-1]);
        }
    }
}
