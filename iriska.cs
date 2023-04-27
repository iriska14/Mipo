using System;
namespace практика
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"a + b = {c}");
            int d = a - b;
            Console.WriteLine($"a - b = {d}");
            int e = a * b;
            Console.WriteLine($"a * b = {e}");
        }
    }
}
