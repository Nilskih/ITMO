using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дано целое число в диапазоне 100–999. 
             * Вывести строку-описание данного числа, например: 
             * 256 — «двести пятьдесят шесть»,
             * 814 — «восемьсот четырнадцать». 
             * Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.*/
            Console.WriteLine("введите число:");           
            int number = Convert.ToInt32(Console.ReadLine());           
            if (number >= 100 && number <= 999)
            {
                Console.WriteLine("число в допустимом диапазоне.");
            }
            else
            {
                Console.WriteLine("число не в допустимом диапазоне.");
                return;
            }
            switch (number / 100)
            {
                case 1: Console.Write("сто");        break;
                case 2: Console.Write("двести");     break;
                case 3: Console.Write("триста");     break;
                case 4: Console.Write("четыреста");  break;
                case 5: Console.Write("пятьсот");    break;
                case 6: Console.Write("шестьсот");   break;
                case 7: Console.Write("семьсот");    break;
                case 8: Console.Write("восемьсот");  break;      
                case 9: Console.Write("девятьсот");  break;
            }
            switch (number % 100) // если есть  уникальные окончания
            {
                case 11: Console.Write(" одинадцать"); break; 
                case 12: Console.Write(" двенадцать"); break;
                case 13: Console.Write(" тренадцать"); break;
                case 14: Console.Write(" четырнадцать"); break;
                case 15: Console.Write(" пятнадцать"); break;
                case 16: Console.Write(" шестнадцать"); break;
                case 17: Console.Write(" семнадцать"); break;
                case 18: Console.Write(" весемнадцать"); break;
                case 19: Console.Write(" девятнадцать"); break;
                default: // условие если нет уникального окончания 11,12,13 и т.д
                    switch (number % 100 / 10)

                    {
                        case 1: Console.Write(" десять"); break;
                        case 2: Console.Write(" двадцать "); break;
                        case 3: Console.Write(" тридцать "); break;
                        case 4: Console.Write(" сорок"); break;
                        case 5: Console.Write(" пятьдесять"); break;
                        case 6: Console.Write(" шестьдесят"); break;
                        case 7: Console.Write(" семьдесят"); break;
                        case 8: Console.Write(" восемьдесят"); break;
                        case 9: Console.Write(" девяносто"); break;


                    }
                    switch (number % 10)
                    {
                        case 1: Console.Write(" один"); break;
                        case 2: Console.Write(" два "); break;
                        case 3: Console.Write(" три "); break;
                        case 4: Console.Write(" четыре"); break;
                        case 5: Console.Write(" пять"); break;
                        case 6: Console.Write(" шесть"); break;
                        case 7: Console.Write(" семь"); break;
                        case 8: Console.Write(" восемь"); break;
                        case 9: Console.Write(" девять"); break;


                    }
                    Console.ReadKey(); break;
            }                    

        }
    }
}
