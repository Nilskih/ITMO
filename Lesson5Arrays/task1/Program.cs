using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Сформировать одномерный массив из 7 элементов. 
          * Заполнить массив числами, вводимыми с клавиатуры 
          * определить среднее арифметическое элементов.*/
            int N = 7;
            int sum=0; //  сумма элементов
            int result; //среднее арифметическое
            int[] mASSive = new int[N];
            Console.WriteLine("введите элементы массива");

            for (int i = 0; i < N; i++) // заполняем массив
            {
                mASSive[i] = Convert.ToInt32(Console.ReadLine());
                sum += mASSive[i];
            }
            result = sum / N;
            Console.WriteLine("среднее арифметическое: "  + result);
        }
    }
}
