using System;
using System.Threading;
using System.Linq;

namespace pz_12
{
    class Program
    {
        static void Main()
        {
            string[] str = new string[4];
            str[0] = "Катя ещё покорит каждого";
            str[1] = "Ты самая лучшая из всех!";
            str[2] = "Как дела?";
            str[3] = "Пока";
            

            var palka = str.OrderBy(a => a.Length);

            foreach (string item in palka)
                Console.WriteLine(item);
        }
    }
}