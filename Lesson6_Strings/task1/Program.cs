using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Ввести с клавиатуры предложение. 
          * Предложение представляет собой слова, разделенные пробелом.
          * Знаки препинания не используются. 
          * Найти самое длинное слово в строке.*/
            Console.WriteLine("введите предложение");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = "";
            foreach ( string s in strArray)
            {
                if (s.Length>max.Length)
                {
                    max = s;
                }
            }

            Console.WriteLine($"самое длинное слово: ,{max}");

        }
    }
}
