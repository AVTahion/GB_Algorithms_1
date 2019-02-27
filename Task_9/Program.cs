using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  9. Даны целые положительные числа N и K.Используя только операции сложения и вычитания,
 *     найти частное от деления нацело N на K, а также остаток от этого деления.

    Александр Кушмилов
*/

namespace Task_9
{
    class Program
    {
        /// <summary>
        /// Метод находит частное деления нацело N на K и остаток.
        /// </summary>
        /// <param name="n">N</param>
        /// <param name="k">K</param>
        /// <param name="x">Остаток от деления</param>
        /// <returns></returns>
        private static int Quotient(int n, int k, out int x)
        {
            x = 0;
            int quo = 0;
            while (n > k)
            {
                n = n - k;
                quo++;
                x = n;
            }
            return quo;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные числа N и K");
            Console.Write("N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("K:");
            int k = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int quotient = Quotient(n, k, out x);
            Console.WriteLine($"Частное деления нацело N на K = {quotient}, остаток: {x}");
            Console.ReadKey();
        }

    }
}
