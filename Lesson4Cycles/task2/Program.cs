using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {/* DO WHILE. 
      * Осуществить ввод последовательности целых чисел и сравнить, что больше,
      * количество положительных или количество отрицательных. 
      * Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/
        static void Main(string[] args)
        {
            int number;
            int CountPozitive = 0;
            int CountNegative = 0;
            Console.WriteLine("вводите числа");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    CountPozitive++;
                }
                else
                {
                    CountNegative++;
                }
            } while (number != 0);
            if (CountPozitive > CountNegative)
            {
                Console.WriteLine("положительных чисел больше");
            }
            else
            {
                Console.WriteLine(" отрицательных чисел больше");
            }



        }
    }
}