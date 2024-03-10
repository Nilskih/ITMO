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
            double ploshad, objem;
            // без инициализации можно передать через out, чтобы метод после обработки этих переменных, вернул их новые значения
            // а ref используем, когда  нам нужно, чтобы результат изменения переменной внутри метода можно было использовать вне метода
            // мы передаем параметр по ссылке, так как уже есть какое-то значение в памяти и метод не будет делать копию параметра, а будет изменять его по ммылке
            // (это мне напоминалочка)
           

            static void CUBE_square_volume(double a, out double volume, out double s )// внутри метра параметры могут называться по другому, главное порядок передачи
            {
                 volume = Math.Pow(a, 3);
                 s = 6 * (a * a);         
            }

            CUBE_square_volume(a, out ploshad, out objem); // вызов нашего ветода, передаем туда все по порядку

            Console.WriteLine($"площадь куба {ploshad}"); // наши переменнык, которые внутри метода были переданы под другим
            Console.WriteLine($"объем куба {objem}");
           ;
        }
    }
}
