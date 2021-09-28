using System;

namespace pz__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            for (int i = 30; i <= 120; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 2");
            for (int i = 0; i < 5; i += 1)
            {
                Console.Write($"{(char)(i + 'M')}\t");
            }
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(new string('#', 4));
            }
            Console.WriteLine("Задание 4");
            for (int i = 0; i <= 100; i += 7)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 5");

            for (int i = 4, j = 50; Math.Abs(i - j) != 12; i++, j--)
            {
                Console.WriteLine("{0} {1}", i, j);
            }
        }
    }
}
