using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
          * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
          * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.*/
            /* абиба боба джон { {залупа упала на лапу апулаз} } }  */
            Console.WriteLine("введите строку");
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();
            Console.WriteLine();
            /*чет я хз пока что*/

           

            string input = "абиба боба джон { {залупа упала на лапу апулаз} }...}";

            // Регулярное выражение для поиска текста в фигурных скобках, включая вложенные скобки
            string pattern = @"(  \{   [^{}]*(    \{   [^{}]*   \}    )*[^{}]*   \}   )";

            // Замена найденных текстов в фигурных скобках на пустую строку
            string result = Regex.Replace(input, pattern, "");

            Console.WriteLine(result); // Вывод: абиба боба джон ...}
        

        }
    }
}
