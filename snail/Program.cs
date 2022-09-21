using System;

namespace snail
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Высота улитки: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ширина улитки: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int [,] snail = new int [size1,size2];
            int value = 0; 
            for (int a = 0; a < (Math.Min(size1, size2)+1)/2; a++)
            {
                    for (int j=a; j < (size2-a); j++)
                           { 
                            value++;
                            snail[a,j] = value;
                            }
                    for (int i=(a+1); i < (size1-a); i++)
                            {
                            value++;
                            snail[i,(size2-1-a)] = value;
                            }
                    for (int j=(size2-2-a); j>=a; j--)
                            {
                                if (size1%2 != 0 && a == Math.Min(size1,size2)/2 && j==size2-a-2) break;
                            value++;
                            snail[(size1-a-1),j] = value;
                            }
                    for (int i=(size1-a-2); i>a; i--)
                            {
                            if (size1%2 != 0 && a == Math.Min(size1,size2)/2 && i==size1-a-2) break;
                            value++;
                            snail[i,a] = value;
                            }
                
            }
            

            for (int i=0; i<size1; i++)
            {
                for (int j=0; j<size2; j++)
                    if (snail[i,j] < 10) Console.Write($"0{snail[i,j]} ");  
                    else Console.Write($"{snail[i,j]} ");
                Console.WriteLine();
            }
        }
        
    }
}
