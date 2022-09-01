// Работа с переменными
// Создайте программу, что будет запрашивать данные пользователя: 
// имя, фамилию, возраст и далее будет выводить их на экран.

using System;

namespace lessons3_5_task5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Вы {name} {surname}, вам {age}");
        }
    }
}
