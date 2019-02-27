using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*      14. * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. Например, 25 \ :sup: '2' = 625. 
            Напишите программу, которая получает на вход натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

    Александр Кушмилов
*/

namespace GB_Algorithms_1
{
    class Program
    {
        /// <summary>
        /// Метод проверяет является ли число автоморфным.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool CheckAutomorphic(int n)
        {
            string lenght = Convert.ToString(n);
            return Math.Pow(n, 2) % Math.Pow(10, lenght.Length) == n;
        }

        /// <summary>
        /// Метод выдает коллекцию автоморфных числел не превосходящих N
        /// </summary>
        /// <param name="n">N</param>
        /// <returns></returns>
        static List<int> AutomorphicNumbers(int n)
        {
            List<int> AutoNumbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (CheckAutomorphic(i)) AutoNumbers.Add(i);
            }
            return AutoNumbers;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            List<int> Automorphic = AutomorphicNumbers(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Автоморфные числа не превосходящие введенное:");
            foreach (var item in Automorphic)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
