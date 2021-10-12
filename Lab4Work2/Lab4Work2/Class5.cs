using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lab4Work2
{
    class A
    {
        public A(string information)
        {
            Input = information;
        }
        public static int number, count = 0;
        public static char symbol;
        public static bool TrueOrFalse, IsTrue;
        public static double PointNumber;
        public static string str;
        private static string input;
        public static string Input
        {
            get
            {
                return input;
            }
            set
            {
                str = value;
                IsTrue = int.TryParse(str, out number);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: число(int)";
                }
                IsTrue = double.TryParse(str, out PointNumber);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: десятичное число(double)";
                }
                IsTrue = char.TryParse(str, out symbol);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: символ(char)";
                }
                IsTrue = bool.TryParse(str, out TrueOrFalse);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: булеан(bool)";
                }
                if (count == 0)
                {
                    value = value + " " + "Тип: строка(string)";
                }
                input = "Значение: " + value + " Модификатор доступа: public";
            }
        }
        public static void Display()
        {
            Trace.WriteLine(input);
        }
    }
}
