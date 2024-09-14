using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(": ");
            int input = Convert.ToInt32(Console.ReadLine());

            int output = input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100);
            Console.WriteLine($"{output}");
            Console.ReadKey();
        }
    }
}