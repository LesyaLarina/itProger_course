// 8.  Получение данных
// Попросите пользователя ввести:
// имя
// возраст
// есть ли у него машина (true или false)
// Выведите все значения, после их получения.

using System;

namespace lesson3_task8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите свое имя:");
            string username = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            byte userage = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Есть ли у вас машина (true или false):");
            bool car = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Пользователя зовут {username}, ему {userage}" );
            Console.WriteLine($"Наличие машины: {car}" );
        }
    }
}
