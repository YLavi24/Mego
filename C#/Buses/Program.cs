using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    internal class Program
    {
        static string[] NotPopular(Bus[] b, int num)
        {
            string[] ret = new string[5];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].GetPassengers()<num)
                    ret[i] = b[i].GetplateNumber();
            }
            return ret;
        }

        static void Main(string[] args)
        {
            Bus[] b = new Bus[5];
            b[0] = new Bus("Alex", "1234", "14", 18);
            b[1] = new Bus("Benny", "7596", "26A", 17);
            b[2] = new Bus("Charly", "6051", "26B", 16);
            b[3] = new Bus("Dani", "4472", "778", 21);
            b[4] = b[3];
            int m = 0, s = 0;
            int x = b[1].GetPassengers();
            b[1].SetPassengers(b[3].GetPassengers() + 5);
            b[3].SetPassengers(x);
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i].GetName() + " " + b[i].GetPassengers());
                s = s + b[i].GetPassengers();
                if (b[i].GetPassengers() > 20) m++;
            }
            Console.WriteLine((double)s / b.Length);
            Console.WriteLine(m);
            for (int i = 0;i < b.Length; i++) 
            {
                Console.WriteLine(NotPopular(b, 22)[i]);
            }
            


        }
    }
}
