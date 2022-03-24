using System;

namespace task_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var input =  Console.ReadLine().Split(' ');
            
            var inputX = int.Parse(input[0]);
            var inputY = int.Parse(input[1]);

            var max = Math.Max(inputX, inputY);

            if (inputX != 0 && inputY != 0)
            {
                max += Math.Min(inputX, inputY);
            }
            
            for (var i = 0; i <= max; i++)
            {
                var x = 0;
                var y = i;
                while (y >= 0)
                {
                    Console.WriteLine($"Пара: ({x}, {y})");
                    
                    if (x == inputX && y == inputY)
                    {
                        return;
                    }
                    
                    x++;
                    y--;
                }
            }

            /*var n = 5;
            for (var i = 0; i <= n; i++)
            {
                var x = 0;
                var y = i;
                while (y >= 0)
                {
                    Console.WriteLine($"Пара: ({x}, {y})");
                    x++;
                    y--;
                }
            }*/
        }
    }
}