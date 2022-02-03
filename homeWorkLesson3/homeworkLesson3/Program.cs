using System;

namespace homeworkLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine($"-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 = {-6 * Math.Pow(x, 2) + 5 * Math.Pow(x, 2) - 10 * x + 15}");
            Console.WriteLine($"abs(x) * sin(x) = { Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"2 * pi * x = {2 * Math.PI * x}");
            Console.WriteLine($"max(x, y) = {Math.Max(x, y)}\n");

            DateTime today= DateTime.Today;
            DateTime pastNY = new DateTime(2022, 1, 1);
            DateTime futureNY = new DateTime(2023, 1, 1);
            Console.WriteLine($"{today}");
            Console.WriteLine($"{(today-pastNY).ToString("%d")} days passed from New Year");
            Console.WriteLine($"{(futureNY - today).ToString("%d")} days left to New Year");

            var i = 5;

            Console.WriteLine(i++);
        }
    }
}
