using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Clock
    {
        int hour;
        int min;
        public Clock(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }
        public int GetHour() { return hour; }
        public int GetMin() { return min; }
        public void SetHour(int hour) { this.hour = hour; }
        public void SetMin(int min) { this.min = min; }
        public int GetInterval()
        {
            int m = 24 * 60;
            int d = hour * 60 + min;
            return m - d;
        }

    }
    internal class Program
    {
        static int GetInterval(Clock c)
        {
            int m = 24 * 60;
            int d = c.GetHour() * 60 + c.GetMin();
            return m - d;
        }
        static int GetFlight(clock c)


        static void Main(string[] args)
        {
            Clock c1 = new Clock(14, 55);
            Clock c2 = new Clock(19, 35);
            Clock c3 = new Clock(21, 5);
            Console.WriteLine(GetInterval(c1));  
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Clock
//    {
//        int hour;
//        int min;
//        public Clock(int hour, int min)
//        {
//            this.hour = hour;
//            this.min = min;
//        }
//        public int GetHour() { return hour; }
//        public int GetMin() { return min; }
//        public void SetHour(int hour) { this.hour = hour; }
//        public void SetMin(int min) { this.min = min; }
//        public int GetInterval()
//        {
//            int m = 24 * 60;
//            int d = hour * 60 + min;
//            return m - d;
//        }

//    }
//    internal class Program
//    {
//        static int GetInterval(Clock c)
//        {
//            int m = 24 * 60;
//            int d = c.GetHour() * 60 + c.GetMin();
//            return m - d;
//        }
//        static void Main(string[] args)
//        {
//            Clock c1 = new Clock(14, 55);
//            Clock c2 = new Clock(19, 35);
//            Clock c3 = new Clock(21, 5);
//            Console.WriteLine(GetInterval(c1));
//            Console.WriteLine(GetInterval(c2));
//            Console.WriteLine(GetInterval(c3));
//            Console.WriteLine(c1.GetInterval());
//            Console.WriteLine(c2.GetInterval());
//            Console.WriteLine(c3.GetInterval());
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Talmid
    {
        private string fName;
        int[] grades = new int[5];
        double ave;
        public void SetFname(string fName)
        {
            this.fName = fName;
        }
        public void SetGrades(int[] grades)
        {
            this.grades = grades;
            ave = 0;
            for (int i = 0; i < grades.Length; i++)
                ave = ave + grades[i];
            ave = ave / grades.Length;
        }
        public double GetAve()
        {
            return ave;
        }
        public string GetFname()
        {
            return fName;
        }
        public int[] GetGrades()
        {
            return this.grades;
        }
    }
    internal class Program
    {
        static Random r = new Random();
        static void ShowBest(Talmid[] k)
        {
            double best = k[0].GetAve();
            int indexOfBest = 0;
            for (int i = 1; i < k.Length; i++)
            {
                if (best < k[i].GetAve())
                {
                    indexOfBest = i;
                    best = k[i].GetAve();
                }
            }
            int[] r = k[indexOfBest].GetGrades();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(r[i]);
            Console.WriteLine(k[indexOfBest].GetAve());
        }
        static void ShowKita(Talmid[] k)
        {

        }
        static void Main(string[] args)
        {
            Talmid[] kita = new Talmid[44];
            for (int i = 0; i < kita.Length; i++)
                kita[i] = new Talmid();
            int[] g = new int[5];
            for (int i = 0; i < kita.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                    g[j] = r.Next(0, 101);
                kita[i].SetGrades(g);
                kita[i].SetFname("RON");
            }
            ShowBest(kita);
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp7
//{
//    class Talmid
//    {
//        private string fName;
//        int[] grades = new int[5];
//        double ave;
//        public void SetFname(string fName)
//        {
//            this.fName = fName;
//        }
//        public void SetGrades(int[] grades)
//        {
//            this.grades = grades;
//            ave = 0;
//            for (int i = 0; i < grades.Length; i++)
//                ave = ave + grades[i];
//            ave = ave / grades.Length;
//        }
//        public double GetAve()
//        {
//            return ave;
//        }
//        public string GetFname()
//        {
//            return fName;
//        }
//        public int[] GetGrades()
//        {
//            return this.grades;
//        }
//    }
//    internal class Program
//    {
//        static Random r = new Random();
//        static void ShowBest(Talmid[] k)
//        {
//            double best = k[0].GetAve();
//            int indexOfBest = 0;
//            for (int i = 1; i < k.Length; i++)
//            {
//                if (best < k[i].GetAve())
//                {
//                    indexOfBest = i;
//                    best = k[i].GetAve();
//                }
//            }
//            int[] r = k[indexOfBest].GetGrades();
//            for (int i = 0; i < 5; i++)
//                Console.WriteLine(r[i]);
//            Console.WriteLine(k[indexOfBest].GetAve());
//        }
//        static void ShowKita(Talmid[] k)
//        {

//        }
//        static void Main(string[] args)
//        {
//            Talmid[] kita = new Talmid[44];
//            for (int i = 0; i < kita.Length; i++)
//                kita[i] = new Talmid();
//            int[] g = new int[5];
//            for (int i = 0; i < kita.Length; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                    g[j] = r.Next(0, 101);
//                kita[i].SetGrades(g);
//                kita[i].SetFname("RON");
//            }
//            ShowBest(kita);
//        }
//    }
//}





////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp6
////{
////    internal class Program
////    {
////        static int F(int x)
////        {
////            if (x > 0)
////                return 1 + F(x / 10);
////            return 0;
////        }
////                static int CountEvensDigits(int x)  //  52
////        {
////            if (x > 0)
////                if (x % 2 == 0)
////                {
////                    return 1 + F(x / 10);   //  1 + ??? =   1+0 =   1
////                }
////                else
////                {
////                    return 0 + F(x / 10);
////                }
////            return 0;
////        }
////        static void Main(string[] args)
////        {
////            Console.WriteLine(CountEvensDigits(52));
////        }
////    }
////}



//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp1
//////{
//////    internal class Program
//////    {
//////        static void ShowEvenOdds(int x)
//////        {
//////            if (x > 0)
//////            {
//////                if (x % 2 == 0)
//////                {
//////                    Console.WriteLine(x % 10);
//////                }
//////                ShowEvenOdds(x / 10);
//////                if (x % 2 == 1)
//////                {
//////                    Console.WriteLine(x % 10);
//////                }
//////            }

//////        }
//////        static void main(string[] args)
//////        {
//////            {
//////                ShowEvenOdds(17984);
//////            }
//////        }
//////    }
//////}










//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp5
//////{
//////    public status int SumDigits (int num)    
//////    {
//////        if
//////            return (num);
//////        return (num % 10 + SumDigits());

//////    }



//////        /*


//////        using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp5
//////{
//////    internal class Program
//////    {
//////        /*

//////        static int G(int x, int y)     //  x=13  y=4
//////        {
//////            if (x >= y)
//////                return 1 + G(x - y, y);
//////            return 0;
//////        }

//////        static void Main(string[] args)
//////        {
//////            int y = G(13, 4);
//////        }
//////    }
//////}
//////        }
//////    }
//////}




//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp5
//////{
//////    internal class Program
//////    {/*

//////        static void F(int x)        //  x =
//////        {
//////            if (x > 0)
//////            {
//////                for (int i = 0; i < x; i++)
//////                    Console.Write("{0} ", x);
//////                Console.WriteLine();
//////                F(x - 1);
//////                for (int i = 0; i < x; i++)
//////                    Console.Write("{0} ", i);
//////                Console.WriteLine();
//////            }
//////        }
//////        static void Main(string[] args)
//////        {
//////            F(5);
//////        }
//////    }
//////}


///////*

//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Runtime.Remoting.Messaging;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp4
//////{
//////    internal class Program
//////    {
//////        static void F(int x)
//////        {
//////            if (x > 0)
//////            {

//////                if (x % 2 == 0) ; 
//////                    Console.WriteLine(x%10);
//////                F(x/10):
//////                if (x % 2 == 1) ;
//////                    Console.Writeline;
//////            }
//////        static voic main(string[] args)
//////                { 
//////                F(6549872)

//////        }            
//////}


///////* 
//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Runtime.Remoting.Messaging;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleApp4
//////{
//////    internal class Program
//////    {
//////        static void Show(int[] x)
//////        { 
//////        static bool F(int[] a)
//////        }
//////       if(a.length%2=0)
//////            return false;
//////        int count = 0;
//////        For(int i = 0; i<a.length; i++)

//////        {





//////        {
//////            for (int i = 0; i < x.Length; i++)
//////                Console.Write(x[i] + "  ");
//////            Console.WriteLine();
//////        }
//////        static bool IsSort(int[] x)
//////        {

//////        }
//////        static void Main(string[] args)
//////        {
//////            int[] a = new int[5] { 5121, 28795, 73, 49, 12345 };
//////            //                      9      31   10  13    15
//////            Show(a);

//////            Show(a);
//////        }
//////    }
//////}



////////using System;
////////using System.Collections.Generic;
////////using System.Linq;
////////using System.Text;
////////using System.Threading.Tasks;

////////namespace ConsoleApp1
////////{
////////    internal class Program
////////    {
////////        static void Show(int[] x)
////////        {
////////            for (int i = 0; i < x.Length; i++)
////////                Console.Write(x[i] + "  ");
////////            Console.WriteLine();
////////        }
////////    }
////////    static void Main(string[] args)
////////    {
////////        0 1 2 3 4  5  6  7
////////         0 1 3 6 10 15 21 28
////////        int[] a = new int[5] { 1, 2, 3, 4, 5 };
////////        show(a);
////////        for (int i = 1; i < a.Length; i++)
////////        {
////////            a[i] = i; +a[i - 2];
////////        }
////////    }
////////}
////////}
