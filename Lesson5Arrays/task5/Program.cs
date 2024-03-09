using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Запросить у пользователя целочисленное значение N. 
          * Сформировать двумерный массив размера NxN следующего вида:*/

            Console.WriteLine("введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mASSive = new int[N, N];
             
              for (int i = 0; i < N; i++)// идем строкам
              {
                  for (int j = 0; j < N; j++)//заполняем строки
                  {
                      if (i==j || i+j==N-1)
                      {
                          mASSive[i,j] = 1;
                          Console.Write("{0,2}", mASSive[i, j]);
                      }
                      else
                      {
                          mASSive[i, j] = 0;
                          Console.Write("{0,2}", mASSive[i, j]);
                      }
                  }
                  Console.WriteLine( );

              }

            string[,] STRONG = new string[N, N];

            for (int i = 0; i < N; i++)// идем строкам
            {
                for (int j = 0; j < N; j++)//заполняем строки
                {
                    if (i == j || i + j == N - 1)
                    {
                        STRONG[i, j] = " происходит ";
                        Console.Write("{0}", STRONG[i, j]);
                    }
                    else
                    {
                        STRONG[i, j] = "ЧЕ_ТУТ ";
                        Console.Write("{0}", STRONG[i, j]);
                    }
                }
                Console.WriteLine($"\n");
            }

        }
    }
}
