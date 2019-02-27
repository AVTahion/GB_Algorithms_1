using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  13. * Написать функцию, генерирующую случайное число от 1 до 100: 
        a. С использованием стандартной функции rand().
        b. Без использования стандартной функции rand().

    Александр Кушмилов
*/

namespace Task_13
{
    class Program
    {
        /// <summary>
        /// Метод генерирует псевдослучайное число от 1 до 100
        /// </summary>
        /// <returns></returns>
        static int Rand()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }

        /// <summary>
        /// Метод ГПСЧ 1 до 99
        /// </summary>
        /// <returns></returns>
        static int RandN()
        {
            int x = 0;
            while (x == 0)
            x = DateTime.Now.Millisecond / 10;
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RandN());
            Console.ReadKey();
        }
    }
}
