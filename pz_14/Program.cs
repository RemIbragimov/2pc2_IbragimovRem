using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string[] mass = File.ReadAllLines(@"C:\pz\14.txt");
            StreamWriter NewFile = File.CreateText(@"F:\pz\123.txt");
            for (a = 0; a < mass.Length; a++)
            {
                if (mass[a] != "")
                {
                    NewFile.WriteLine(mass[a]);
                }
            }
            NewFile.Close();
        }
    }
}
