using System;
using System.Collections.Generic;

namespace Between
{
    /*
     * функция int[] Between(int a, int b), которая возвращает массив int[] с числами между a и b
     */
    class Program
    {
        static void Main()
        {
            Read read = new Read();            
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            List<int> result = result = read.Between(a, b);
            Console.WriteLine("Numbers in the indicated interval: ");
            for (int i = 0; i < result.Count; i++)                        
                Console.WriteLine($"{result[i]}");
                      
            Console.ReadLine();
        }
        
    }
}
