using System;
using System.Diagnostics;

namespace Lab4Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            B1 example1 = new B1();
            B2 example2 = new B2();
            B3 example3 = new B3();
            string information;
            information = B1.argument1;
            A A1 = new A(information);
            A.Display();
            information = B2.argument2;
            A A2 = new A(information);
            A.Display();
            information = B3.argument3;
            A A3 = new A(information);
            A.Display();
        }
    }
}
