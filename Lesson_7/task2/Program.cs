using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double ploshad, objem; // без инициализации можно передать через out
                                   // а ref используем, когда  нам нужно, чтобы результат изменения переменной внутри метода можно было использовать вне метода
                                   // мы передаем параметр по ссылке, и метод не будет делать копию параметра, а будет изменять его по ммылке (это мне напоминалочка)
            CUBE_square_volume(a, out ploshad, out objem);

            static void CUBE_square_volume(double a, out double volume, out double s )// внутри метра параметры могут называться по другому, главное порядок передачи
            {
                 volume = Math.Pow(a, 3);
                 s = 6 * (a * a);         
            }


            Console.WriteLine($"площадь куба {ploshad}");
            Console.WriteLine($"объем куба {objem}");
           ;
        }
    }
}
