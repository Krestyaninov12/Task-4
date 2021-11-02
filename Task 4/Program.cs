using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, sum, i;
            Console.WriteLine("Введите значение N >0");
            N = Convert.ToInt16(Console.ReadLine());
            i = 1;
            sum = 0;

            for (; i <= ((2 * N) - 1);)

            {
                sum += i;
                Console.WriteLine("Текущее значение суммы {0} ", sum);
                i += 2;
            }
                        
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
