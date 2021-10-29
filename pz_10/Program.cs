using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //1
            int[][] list = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                list[i] = new int[rd.Next(5, 50)];
                for (int y = 0; y < list[i].Length; y++)
                {
                    list[i][y] = rd.Next(0, 100);
                }
            }
            //2           
            Console.WriteLine("Массив:");
            foreach (int[] i in list)
            {
                foreach (int y in i) Console.Write(y + "\t");
                Console.WriteLine();
            }
            //3
            int[] values = new int[4];
            for (int i = 0; i < 4; i++)
            {
                values[i] = list[i][list[i].Length - 1];
            }
            Console.WriteLine("Последние значения:");
            foreach (int i in values)
            {
                Console.Write(i + "\t");

            }
            Console.WriteLine();
            //4
            for (int i = 0; i < 4; i++)
            {
                values[i] = list[i].Max();
            }
            Console.WriteLine("Максимальные значения:");
            foreach (int i in values)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //5
            for (int i = 0; i < 4; i++)
            {
                int position = Array.IndexOf(list[i], values[i]);
                list[i][position] = list[i][0];
                list[i][0] = values[i];
            }
            Console.WriteLine("Массив:");
            foreach (int[] i in list)
            {
                foreach (int y in i) Console.Write(y + "\t");
                Console.WriteLine();
            }
        }
    }
}
