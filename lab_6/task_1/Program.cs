using System;

namespace task_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine() ?? string.Empty);
            for (var i = 0; i <= n; i++)
            {
                var x = 0;
                var y = i;
                while (y >= 0)
                {
                    Console.WriteLine($@"Пара: ({x}, {y})");
                    x++;
                    y--;
                }
            }
        }
    }
}