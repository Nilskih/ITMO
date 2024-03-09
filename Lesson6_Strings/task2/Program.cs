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
        {/*Ввести с клавиатуры предложение. 
          * Предложение представляет собой слова, разделенные пробелом. 
          * Знаки препинания не используются. Составить программу, 
          * определяющую является ли строка палиндромом без учёта пробелов и регистра 
          * (пример палиндрома – «А роза упала на лапу Азора»).*/

            Console.WriteLine("введите предложение");
            string str = Console.ReadLine();
            str.ToLower();                                        //на всякий пожарный
            string reverse = new string (str.Reverse().ToArray());// создаем новую строку из перевернутой строки str  
            if (str==reverse)
            {
                Console.WriteLine("палиндром");
            }
            else
            {
                Console.WriteLine("не палиндром");
            }
        }
    }
}
