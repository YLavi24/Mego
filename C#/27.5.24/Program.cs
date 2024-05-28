using System;
using System.Runtime.ConstrainedExecution;


    class A
    {
        int value;
        A next;
        public A(int value, A next)
        {
            this.value = value;
            this.next = next;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetNext(A next)
        {
            this.next = next;
        }
        public A GetNext()
        {
            return this.next;
        }
    }
    class P
    {
        static Random rnd = new Random();
        static void Show(A first)
        {
            while (first != null)
            {
                Console.WriteLine(first.GetValue());
                first = first.GetNext();
            }
        }
        static A BuildList()
        {
            A o = new A(111, null); //  SRAK
            A ezer = o;
            Console.Write("More ? ");
            char yN = char.Parse(Console.ReadLine());
            while (yN != 'n')
            {
                A t = new A(rnd.Next(11, 77), null);
                ezer.SetNext(t);
                ezer = ezer.GetNext();
                Console.Write("More ? ");
                yN = char.Parse(Console.ReadLine());
            }
            return o;
        }
        static int SumList(A list)
        {
            int sum = 0;
            while (list != null)
            {
                sum += list.GetValue();
                list = list.GetNext();
            }
            return sum;
        }
        static void ShowRec(A list)
        {
            if (list != null)
            {
                ShowRec(list.GetNext());
                Console.WriteLine(list.GetValue());
            }
        }
        static void DelThird(A list)
        {
            A list2 = list.GetNext();
            list2 = list2.GetNext();    //  5
            list = list2.GetNext();     //  4
            list2.SetNext(list.GetNext());
            list.SetNext(null);
        }
        static void ShowEvensFirst(A list)
        {
            if (list != null)
            {
                if (list.GetValue() % 2 == 0)
                    System.Console.Write(list.GetValue() + " ");
                ShowEvensFirst(list.GetNext());
                if (list.GetValue() % 2 == 1)
                    System.Console.Write(list.GetValue() + " ");
            }
        }
        public static void Main(string[] args)
        {
            A list = new A(11, null);
            list = BuildList();
            ShowEvensFirst(list);
            Show(list);
        }
    }
