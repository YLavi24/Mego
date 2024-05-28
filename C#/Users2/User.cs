using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users2
{
    internal class User
    {
        int id, age;
        string name;
        User link = null; 

        public User()
        {
            Console.Write("Enter your name: ");
            this.name= Console.ReadLine();
            Console.Write("Enter your age: ");
            this.age = int.Parse(Console.ReadLine());
            this.id++;

            Console.Write("Enter your id: ");
            this.id = int.Parse(Console.ReadLine());
        }

    }
}
