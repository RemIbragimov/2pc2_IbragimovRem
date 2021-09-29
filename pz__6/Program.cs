using System;

namespace pz__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (n >= 2)
            {
                k++;
                n /= 2;
            }
            Console.WriteLine(k);
        }
    }
}
