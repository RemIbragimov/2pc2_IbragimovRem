using System;
using System.Collections.Generic;
using System.Text;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 6, 21, -123, 4, 1, 6, 12, 641, 7, 312 };

            int middle = 0;

            int array_count = array.Length; 
            int summary = 0;
        
            for (int i = 0; i < array_count; i++)
            {
                summary += array[i];
            }
            middle = summary / array_count;
            Console.WriteLine("Среднее арифметическое: {0}", middle);

            
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < array_count; i++)
            {
                int val = array[i];
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }

            Console.WriteLine("Минимальное значение: {0}\nМаксимальное значение: {1}", min, max);
            Console.ReadLine();
        }
    }
}
