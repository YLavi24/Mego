


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static int F(int x)
        {
            if (x > 0)
                return 1 + F(x / 10);
            return 0;
        }
                static int CountEvensDigits(int x)  //  52
        {
            if (x > 0)
                if (x % 2 == 0)
                {
                    return 1 + F(x / 10);   //  1 + ??? =   1+0 =   1
                }
                else
                {
                    return 0 + F(x / 10);
                }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountEvensDigits(52));
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void ShowEvenOdds(int x)
//        {
//            if (x > 0)
//            {
//                if (x % 2 == 0)
//                {
//                    Console.WriteLine(x % 10);
//                }
//                ShowEvenOdds(x / 10);
//                if (x % 2 == 1)
//                {
//                    Console.WriteLine(x % 10);
//                }
//            }

//        }
//        static void main(string[] args)
//        {
//            {
//                ShowEvenOdds(17984);
//            }
//        }
//    }
//}


        







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    public status int SumDigits (int num)    
//    {
//        if
//            return (num);
//        return (num % 10 + SumDigits());

//    }



//        /*


//        using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    internal class Program
//    {
//        /*

//        static int G(int x, int y)     //  x=13  y=4
//        {
//            if (x >= y)
//                return 1 + G(x - y, y);
//            return 0;
//        }

//        static void Main(string[] args)
//        {
//            int y = G(13, 4);
//        }
//    }
//}
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5
//{
//    internal class Program
//    {/*

//        static void F(int x)        //  x =
//        {
//            if (x > 0)
//            {
//                for (int i = 0; i < x; i++)
//                    Console.Write("{0} ", x);
//                Console.WriteLine();
//                F(x - 1);
//                for (int i = 0; i < x; i++)
//                    Console.Write("{0} ", i);
//                Console.WriteLine();
//            }
//        }
//        static void Main(string[] args)
//        {
//            F(5);
//        }
//    }
//}


///*

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void F(int x)
//        {
//            if (x > 0)
//            {

//                if (x % 2 == 0) ; 
//                    Console.WriteLine(x%10);
//                F(x/10):
//                if (x % 2 == 1) ;
//                    Console.Writeline;
//            }
//        static voic main(string[] args)
//                { 
//                F(6549872)

//        }            
//}


///* 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Show(int[] x)
//        { 
//        static bool F(int[] a)
//        }
//       if(a.length%2=0)
//            return false;
//        int count = 0;
//        For(int i = 0; i<a.length; i++)

//        {





//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + "  ");
//            Console.WriteLine();
//        }
//        static bool IsSort(int[] x)
//        {

//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[5] { 5121, 28795, 73, 49, 12345 };
//            //                      9      31   10  13    15
//            Show(a);

//            Show(a);
//        }
//    }
//}



////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp1
////{
////    internal class Program
////    {
////        static void Show(int[] x)
////        {
////            for (int i = 0; i < x.Length; i++)
////                Console.Write(x[i] + "  ");
////            Console.WriteLine();
////        }
////    }
////    static void Main(string[] args)
////    {
////        0 1 2 3 4  5  6  7
////         0 1 3 6 10 15 21 28
////        int[] a = new int[5] { 1, 2, 3, 4, 5 };
////        show(a);
////        for (int i = 1; i < a.Length; i++)
////        {
////            a[i] = i; +a[i - 2];
////        }
////    }
////}
////}
