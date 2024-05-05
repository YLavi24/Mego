using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[22];
            // 0 1 2 3 4  5  6  7
            // 0 1 3 6 10 15 21 28
            a[0] = 0;
            for (int i = 1; i < a.Length; i++)
                a[i] = i; +a[i - 2];
        }
    }
}
