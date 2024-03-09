using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
                * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.    */

            int N = 10;//размерность массива          
            int[] mASSive = new int[N];
            Random random = new Random();

            for (int i = 0; i < N; i++) // рандомно заполняем массив 
            {
                mASSive[i] = random.Next(-50, 50);
                Console.Write("{0,3} ", mASSive[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)// упорядочим первую половину  по возрастанию
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    if (mASSive[i] > mASSive[j])
                    {
                        int t = mASSive[i];
                        mASSive[i] = mASSive[j]; 
                        mASSive[j] = t;                     
                    }
                }
            }
         
            for (int a = 5; a > 4 && a < 10; a++)// упорядочим вторую половину  по убыванию
            {
                for (int b = a + 1; b < 10; b++)
                {
                    if (mASSive[a] < mASSive[b])
                    {
                        int t = mASSive[a];
                        mASSive[a] = mASSive[b]; 
                        mASSive[b] = t;
                    }
                }
            }
            foreach (int x in mASSive)//вывод
            {
                Console.Write("{0,3} ", x);
            }
            Console.ReadKey();
        }
    }
}
