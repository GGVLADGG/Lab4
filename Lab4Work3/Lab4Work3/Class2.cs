using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lab4Work3
{
    class Documents : Passport
    {
        string dostyp = "public";
        public Documents()
        {
            Trace.WriteLine("Тип доступа: " + dostyp + " Тип: " + years.GetTypeCode() + " Название переменной: years " + "Значение: " + years);
            Trace.WriteLine("Тип доступа: " + dostyp + " Тип: " + name.GetTypeCode() + " Название переменной: name " + "Значение: " + name);
            Trace.WriteLine("Тип доступа: " + dostyp + " Тип: " + surname.GetTypeCode() + " Название переменной: surname " + "Значение: " + surname);
            Trace.WriteLine("Тип доступа: " + dostyp + " Тип: " + DateOfBirth.GetTypeCode() + " Название переменной: DateOfBitrh " + "Значение: " + DateOfBirth);
            Trace.WriteLine("Тип доступа: " + dostyp + " Тип: " + country.GetTypeCode() + " Название переменной: country " + "Значение: " + country);
        }
    }
}
