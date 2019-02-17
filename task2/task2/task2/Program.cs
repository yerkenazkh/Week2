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
        static public bool Prime(int b) // Function, which determine the prime number
        {
            if (b == 1) return false;

            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false;// if the number will have reminder 0, when it divide to number between 2 and b, it is false 
            }
            return true;
        }
        static void Main()
        {
            StreamReader r = new StreamReader(@"D:\csharp\week2\task2\task2\1.txt");
            StreamWriter w = new StreamWriter(@"D:\csharp\week2\task2\task2\2.txt");
            string [] n = r.ReadToEnd().Split(' ');
            foreach (string s in n)
            {
                if (Prime(Convert.ToInt32(s))== true)
                {
                    w.Write(s + " ");
                }
            }
            r.Close();
            w.Close();
        }
    }
}
