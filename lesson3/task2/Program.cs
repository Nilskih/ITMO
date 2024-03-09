namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*На числовой оси расположены три точки: A, B, C.
           Определить, какая из двух последних точек (B или C) расположена ближе к A,
           и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так,
           что они будут равноотстоящими от А, совпадать с А или между собой - 
           выдать соответствующее сообщение.*/

            Console.WriteLine("введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число C");
            int C = Convert.ToInt32(Console.ReadLine());

            int neighbor; 
            if (A!=C && A!=B && B!=C)// проверка на честность
            {
                neighbor = (Math.Abs(A - B) < Math.Abs(A - C)) ? B : C;
                Console.WriteLine($"\nближайщее число к A: {neighbor}\nрасстояние до числа A: {Math.Abs(A - neighbor)}");
            }
            else
            {
                Console.WriteLine($"\nне верный ввод");
            }
        }
    }
}