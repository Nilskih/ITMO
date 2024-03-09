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
            /*Ввести положительные числа A, B, C. 
             * На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).
             * Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.*/

            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата C: ");
            int C = int.Parse(Console.ReadLine());
            // Проверка, что квадрат со стороной C может быть размещен целиком в прямоугольнике, а то я вас знаю
            if (C > A || C > B)
            {
                Console.WriteLine("Квадрат со стороной C не может быть размещен целиком в прямоугольнике");
                return;
            }
            int count = 0; //счетчик кол-ва квадратов
            int result = 0;
            if (A > B) 
            {
                int Ac = A;// переменная для расчетов размещения по ширине
                while (Ac >= C)
                {
                    Ac = Ac - C; // сколько раз сторона квадрата С  поместится в длину A
                    count++;
                }
                result = count * (B / C); // тут дополнительно определяем, позволяет ли ширина прямоугольника разместить еще квадраты
            }
            else
            {
                int Bc = B; // переменная для расчетов размещения по ширине
                while (Bc >= C)
                {
                    Bc = Bc - C; // сколько раз сторона квадрата С  поместится в длину B
                    count++;
                }
                result = count * (A / C);
            }
            Console.WriteLine("Количество квадратов: " + result);
        }
    }
}

