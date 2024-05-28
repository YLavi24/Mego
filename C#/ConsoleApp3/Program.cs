using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class box
    {
        string color;
        int length;
        int width;
        int height;

        public box(string color, int length, int width, int height)
        {
            this.color = color;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public box(string color)
        {
            this.color = color;
            this.length = 10;
            this.width = 10;
            this.height = 10;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setLength(int length)
        {
            this.length = length;
        }
        public int getLength()
        {
            return this.length;
        }
        public void setwidth(int width)
        {
            this.width = width;
        }
        public int getwidth()
        {
            return this.width;
        }
        public void setheight(int height)
        {
            this.height = height;
        }
        public int getheight()
        {
            return this.height;
        }


    }




    internal class Program
    {
        static string smallbox(box[] arr)
        {
            int small = 0;
            int volume = arr[0].getLength() * arr[0].getheight() * arr[0].getwidth();
            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i].getLength() * arr[i].getheight() * arr[i].getwidth();
                if (volume > next)
                    small = i;
            }
            return arr[small].getColor();
        }
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple", "Orange" };
            Random rnd = new Random();

            box[] arr = new box[10];
            for (int i = 0; i < arr.Length; i++)
            {
                int a = rnd.Next(0, 6);
                arr[i] = new box(colors[a]);
            }
            Console.WriteLine(smallbox(arr));
        }
    }
}