namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
             * Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»
             * например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». 
             * Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.*/
            Console.WriteLine("введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 20 && age <= 69)
            {
                Console.WriteLine("Возраст в допустимом диапазоне.");
            }
            else
            {
                Console.WriteLine("Возраст не в допустимом диапазоне.");
                return;
            }

            switch (age / 10)
            {
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
            }
            switch (age % 10)
            {
                case 1:
                    Console.WriteLine("один год ");
                    break;
                case 2:
                    Console.WriteLine("два года ");
                    break;
                case 3:
                    Console.WriteLine("три года ");
                    break;
                case 4:
                    Console.WriteLine("четыре года ");
                    break;
                case 5:
                    Console.WriteLine("пять лет ");
                    break;
                case 6:
                    Console.WriteLine("шесть лет ");
                    break;
                case 7:
                    Console.WriteLine("семь лет ");
                    break;
                case 8:
                    Console.WriteLine("восемь лет ");
                    break;
                case 9:
                    Console.WriteLine("девять лет ");
                    break;
                

                default: Console.WriteLine("лет");
                    break;

            }
        }
    }
}