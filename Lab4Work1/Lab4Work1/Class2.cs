using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lab4Work1
{
    class Display : Outputer
    {
        private static bool IsTrue;
        private static bool i;
        private static int number;
        private static char symbol;
        private static double NumberPoint;
        public static void Check()
        {
            IsTrue = int.TryParse(input, out number);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: число(int)");
            }
            IsTrue = char.TryParse(input, out symbol);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: символ(char)");
            }
            IsTrue = bool.TryParse(input, out i);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: bool");
            }
            IsTrue = double.TryParse(input, out NumberPoint);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: десятичное число(double)");
            }
            Trace.WriteLine("Тип: строка(string)");
        }
        public static void Show()
        {
            Trace.WriteLine(input);
            Check();
        }
    }
}
