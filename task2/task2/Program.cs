using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 11;
            Console.WriteLine((Math.Pow(a - b, 4) - (Math.Pow(a, 4) - 4 * Math.Pow(a, 3) * b))
                / (6 * Math.Pow(a, 2) * Math.Pow(b, 2) - 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4)));
            Console.ReadKey();
        }
    }
}