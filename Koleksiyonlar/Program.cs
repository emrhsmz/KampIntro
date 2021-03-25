using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; // yeni bir referans adres belirliyoruz.
            isimler[4] = "İlker";
            // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            // array ilk oluşturulduğunda içinde yer alan değerler kadar oluşur.
            Console.WriteLine(isimler[4]);
            Console.WriteLine(" -> " + isimler[0]); // biz yeni bir referans adres belirlediğimiz için 0 indisini bulamamaktadır.

            */

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            Console.WriteLine("");
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
