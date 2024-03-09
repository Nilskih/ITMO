using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Сформировать одномерный массив из 15 элементов,
             * которые выбираются случайным образом из диапазона[0; 50]. 
              Определить сумму максимального и минимального элементов массива.*/

            int N = 15;//размерность массива
            int sum = 0; //  сумма
            int result = 0;
            int[] mASSive = new int[N];
            Random random = new Random();

            for (int i = 0; i < N; i++) // рандомно заполняем массив 
            {
                mASSive[i] = random.Next(0, 50);
                Console.WriteLine(mASSive[i]);
                sum += mASSive[i];
            }
            // найдем максимальный элемент
            int max = mASSive[0];
            foreach (int a in mASSive)
            {
                if (a > max)
                    max = a;
            }
            // найдем минимальный элемент
            int min = mASSive[0];
            foreach (int a in mASSive)
            {
                if (a < min)
                    min = a;
            }
            result = min + max;
            Console.WriteLine("сумма минимального и максимального элемента: " + result);         
        }
    }
}
