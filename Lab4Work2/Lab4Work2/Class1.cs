using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Work2
{
    public class Б
    {
        protected static string argument;
        public static void Show()
        {
            Console.WriteLine("Введите аргумент: ");
            argument = Console.ReadLine();
        }
    }
}
