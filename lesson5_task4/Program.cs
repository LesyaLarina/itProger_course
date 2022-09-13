// Условные операторы
// Создайте переменную, в которой будет указан возраст пользователя, соблюдая при этом следующие 
// условия проверки:
// если возраст больше 18 – на экран выводиться предложение: «You can do everything»;
// если возраст равен 18 – «Hoho, you're 18!»;
// если меньше 18 – «You are too young».

using System;

namespace lesson5_task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите возраст:");
            byte age = Convert.ToByte(Console.ReadLine());
            if (age > 18) 
                Console.WriteLine("You can do everything");
            else if (age == 18) 
                Console.WriteLine("Hoho, you're 18!");
            else Console.WriteLine("You are too young");
        }
        
    }
}
