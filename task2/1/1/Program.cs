using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool Prime(int b)
        {
            if (b == 1) return false;
            {
                for (int i = 2; i < b; i++)
                    if (b % i == 0) return false;
            }
            return true;
        }
        static void Main()
        {
            StreamReader r = new StreamReader(@"D:\csharp\week2\task2\task2\1.txt");
            StreamWriter w = new StreamWriter(@"D:\csharp\week2\task2\task2\2.txt");
            string n = r.ReadToEnd();
            string[] a = n.Split(' ');
            foreach (string s in a)
            {
                if (Prime(Convert.ToInt32(s)))
                    w.Write(s + ' ');
            }
            r.Close();
            w.Close();
        }
    }
}
