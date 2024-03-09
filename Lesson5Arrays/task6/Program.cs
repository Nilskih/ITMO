using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Запросить у пользователя целочисленное значение N.
          * Сформировать двумерный массив размера NxN. 
          * Заполнить массив числами, вводимыми с клавиатуры.
          * Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
          * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, 
          * в каждом столбце и по каждой диагонали одинакова.
          */
            Console.WriteLine("введите размер  матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mASSive = new int[N, N];// исходный массив
            int[] lines = new int[(N + N) + 2];//  массив сумм горизонталей, вертикалей и диагоналей 
            Console.WriteLine("вводите элементы матрицы, Мистер Андерсон");

            for (int i = 0; i < N; i++)        //переключаемся по строкам, заполняя массив
            {
                for (int j = 0; j < N; j++)    //заполняем строки
                {
                    mASSive[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //  будем находить суммы строк и стобцов и записывать в lines
            for (int L = 0; L < N; L++)
            {
                for (int i = 0; i < 1; i++)              //берем строку i
                {
                    for (int j = 0; j < N; j++)          //берем каждый отдельный элемент
                    {
                        lines[L] += mASSive[i, j];       // и ЗЗАКИДЫВАЕМ
                    }
                }
            }

            Console.WriteLine();
            foreach (int x in lines)                    //графический вывод
            {
                Console.Write("{0,3} ", x);
            }

            for (int L = N; L < lines.Length - 2; L++)
            {
                for (int i = 0; i < 1; i++)              //берем столбец  i
                {
                    for (int j = 0; j < N; j++)          //берем каждый отдельный элемент
                    {
                        lines[L] += mASSive[j, i];       // и ЗЗАКИДЫВАЕМ
                    }
                }
            }

            Console.WriteLine();
            foreach (int x in lines)                     //графический вывод
            {
                Console.Write("{0,3} ", x);
            }

            //считаем по диагоналям
            for (int L = N + N + 1; L < N + N - 1; L++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i == j)
                        {
                            lines[L] += mASSive[i, j];
                        }

                    }
                }
            }

            // я не могу больше
            for (int L = N + N; L < lines.Length; L++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i + j == N - 1)
                        {
                            lines[L] += mASSive[i, j];
                        }

                    }
                }
            }

            Console.WriteLine();
            foreach (int x in lines)                     //графический вывод
            {
                Console.Write("{0,3} ", x);
            }

            for (int i = 1; i < lines.Length; i++)  //проверка равенства всех сумм
            {
                if (lines[i] != lines[0])
                {                 
                    Console.WriteLine("\n это НЕ магический квадрат");
                    return;
                }
                else
                {
                    Console.WriteLine("\nэто  магический квадрат");
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
