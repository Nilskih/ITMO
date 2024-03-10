using System.Collections.Concurrent;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Два треугольника заданы длинами своих сторон. 
             * Определить, площадь какого из них больше
             * (создать метод для вычисления  площади  треугольника по длинам его сторон).  
             * Для решения задачи можно использовать формулу Герона */
            Console.WriteLine("введите стороны первого треугольника");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите стороны второго треугольника");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            double c1 = Convert.ToInt32(Console.ReadLine());

            Find_S_triangle(a, b, c, a1, b1, c1);

            static void Find_S_triangle(double a, double b, double c, double a1, double b1, double c1)
            {
                double p = (a + b + c) / 2;
                double s = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);//с округлением до двух знаком после запятой
                Console.WriteLine($"площадь первого треугольника:{s}");

                double p1 = (a1 + b1 + c1) / 2;
                double s1 = Math.Round(Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1)), 2);
                Console.WriteLine($"площадь второго треугольника:{s1}");

                if (s > s1)
                {
                    Console.WriteLine("площадь первого треугольника больше");
                    // Код для случая, когда s > s1
                }
                else if (s < s1)
                {
                    Console.WriteLine("площадь второго треугольника больше");
                    // Код для случая, когда s < s1
                }
                else
                {
                    Console.WriteLine("у трекгольников одинаковая площадь");
                    // Код для случая, когда s == s1
                }
            };
        }
    }
}

