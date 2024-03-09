namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
          * Найти координаты его четвертой вершины. 
          * Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,
          * параллельными координатным осям, вывести соответствующее сообщение.*/
            int x4; int y4;
             
            Console.WriteLine("введите координаты первой точки: "); 
             int x1 = Convert.ToInt32 (Console.ReadLine());
             int y1 = Convert.ToInt32 (Console.ReadLine()); 

             Console.WriteLine("введите координаты второй точки: ");
             int x2 = Convert.ToInt32 (Console.ReadLine());
             int y2 = Convert.ToInt32 (Console.ReadLine());
                if (x2 == x1 && y2 == y1)
                {
                Console.WriteLine("вы задали две одинаковые точки!");// проверка на честность                  
                Console.ReadKey();
                return;
                }

             Console.WriteLine("введите координаты третьей точки ");        
             int x3 = Convert.ToInt32(Console.ReadLine());
             int y3 = Convert.ToInt32(Console.ReadLine());
                if ((x3 == x1 && y3 == y1) || (x3==x2 && y3==y2))
                 {
                 Console.WriteLine("вы задали две одинаковые точки. Не балуйтесь!");
                 Console.ReadKey();
                 return;
                 }          

            
            if ((x1 == x2 || x1 == x3 || x2 == x3)    &&     (x1 != x2 || x1 != x3 || x2 != x3)) // проверка параллельности осям координат
            {
                if ((y1 == y2 || y1 == y3 || y2 == y3) && (y1 != y2 || y1 != y3 || y2 != y3))
                {
                    Console.WriteLine($"\n все гуд, сейчас вычислим вершину");
                    if (x1==x2)
                    {
                         x4 = x1 + x3 - x2;
                    }
                    else
                    {
                         x4 = x1 + x2 - x3;
                    }
                    if (y1 == y2)
                    {
                         y4 = y1 + y3 - y2;
                    }
                    else
                    {
                         y4 = y1 + y2 - y3;
                    }
                    Console.WriteLine($"\n координаты четвертой вершины : ({x4},{y4}). ");

                }

                else
                {
                    Console.WriteLine("не возможно построить.");
                }


            }

            else
            {
                Console.WriteLine("не возможно построить.");
            }





        }
    }
}