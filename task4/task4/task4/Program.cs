using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter w = new StreamWriter(@"D:\csharp\week2\task4\task4\1.txt");
            w.Write("Yerkenaz");
            w.Close();
            File.Copy(@"D:\csharp\week2\task4\task4\1.txt", @"D:\csharp\week2\task4\task4\2.txt");
            File.Delete(@"D:\csharp\week2\task4\task4\1.txt");
        }
    }
}
