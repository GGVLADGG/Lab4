using System;
using System.Diagnostics;

namespace Lab4Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Outputer.Input();
            Display.Show();
        }
    }
}
