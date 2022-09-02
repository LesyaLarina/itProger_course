// Пустая строка
// Создайте программу для получения строки от пользователя.
// Если пользователь будет вводить пустую строку, то программа будет заново запрашивать строку. Программа 
// должна запрашивать строку до тех пор, пока пользователь не введет какое-либо значение с клавиатуры.

using System;

namespace lessons3_5_task8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст");
            string? text = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(text)) 
            {Console.WriteLine("Попробуйте еще раз");
            text = Console.ReadLine();}
           
        }   
         
    }
}