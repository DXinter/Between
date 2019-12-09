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
            int a, b;
            Set(out a, out b);
            List<int> result = result = read.Between(a, b);
            Results(result);

        }

        private static void Results(List<int> result)
        {
            Console.WriteLine("Numbers in the indicated interval: ");
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine($"{result[i]}");
        }

        private static void Set(out int a, out int b)
        {
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
        }
       
    }
}
