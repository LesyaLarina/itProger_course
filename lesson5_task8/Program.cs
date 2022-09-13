// Среднее число
// Создайте программу, которая будет находить среднее из трех произвольных чисел. 
// В случае их совпадения программа выводит слово «Ошибка».

using System;

namespace lesson5_task8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 3 числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2 && num1 == num3) 
                Console.WriteLine("Ошибка, все числа равны");
            else if (num1 < num2 && num1 > num3 || num1 > num2 && num1 < num3) 
             Console.WriteLine($"Их среднее (медианное) - это {num1}"); 
            else if (num2 < num1 && num2 > num3 || num2 > num1 && num2 < num3) 
             Console.WriteLine($"Их среднее (медианное) - это {num2}"); 
            else if (num3 < num2 && num3 > num1 || num3 > num2 && num3 < num1) 
             Console.WriteLine($"Их среднее (медианное) - это {num3}");  
            else 
                Console.WriteLine("Два из введенных чисел равны");
            
            
            

        }
    }
}
