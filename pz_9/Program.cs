using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int sum = 0;
            int[] S = new int[4];
            int[,] A = new int[3, 4];
            Console.WriteLine("Массив А: ");
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 3; j++)

                {
                    A[i, j] = i + 4 * j + 1;
                    Console.Write(A[i, j] + " ");

                    sum += A[i, j];
                }
                Console.WriteLine("=" + " " + sum);
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        S[i] += A[j, i];
                    }
                }

            }
        }
    }
}
