using System;

namespace Lab4Work4
{
    class ApplicationLicense
    {
        private static void AllowTrial()
        {
            Console.WriteLine("Триальный режим");
        }
        private static void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия");
        }
        private static void AllowPro()
        {
            Console.WriteLine("Платная версия");
        }
        public ApplicationLicense(string Key)
        {
            if (Key == "123")
            {
                AllowTrial();
            }
            else if (Key == "456")
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите ключ доступа (123 - Триальная версия, 456 - Полная версия)");
            Console.WriteLine("Если ключ не введен, или введен неверно, пользователь получит доступ к бесплатной версии");
            string Key = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense(Key);
        }
    }
}
