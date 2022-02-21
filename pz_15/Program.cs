using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        private static object nums;

        static void Main(string[] args)
        {
            string path = @"C:\Users\1073\Desktop";
            string subpath = @"new";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);

                var myFile = File.Create(@"C:\Users\1073\Desktop\new\f2.txt");

                myFile.Close();

                File.AppendAllText(@"C:\Users\1073\Desktop\new\f2.txt", File.ReadAllText(@"C:\Users\1073\Desktop\f1.txt"));

            }
        }
    }
}