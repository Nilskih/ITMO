using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {/* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
      * Определить количество   нечетных положительных элементов, стоящих на четных местах.*/
      
        static void Main(string[] args)
        {
            int N = 20;//размерность массива          
            int[] mASSive = new int[N];
            int count = 0;
            Random random = new Random();

            for (int i = 0; i < N; i++) // рандомно заполняем массив 
            {
                mASSive[i] = random.Next(-50, 50);
                Console.Write("{0,3} ", mASSive[i]);
            }

            Console.WriteLine();

            for (int i = 2; i < N; i++) // здесь зададим i так, чтобы начать обработку от второй позиции.(т.к первая не четная)                                    
            {                                                             //если считать, что нулевой и первый элемент, это нечетные числа
                if (mASSive[i] % 2 == 0 && mASSive[i] > 0)
                {
                    count++;
                    Console.Write("{0,3} ", mASSive[i]);
                }
                i++;// чтобы по итогу каждой итерации шагать не на 1 одну позицию, а на две, т.е по четным местам
            }
            Console.WriteLine($"\n вывод: " + count); 
            Console.ReadKey();

        }
    }
}
