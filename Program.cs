using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void Greet(string name);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate ()
            {
                Console.WriteLine("Shalom!!");
            };

            MyDelegate myDelegate1 = delegate ()
            {
                Console.WriteLine("Another");
            };

            Greet greet = delegate (string name)
            {
                Console.WriteLine("Shalom to " + name);
            };

            Greet greet1 = delegate (string name)
            {
                Console.WriteLine("Welcome to " + name);
            };

            myDelegate();
            myDelegate1();
            greet("ohad");
            greet1("ohad");


        }
    }
}
