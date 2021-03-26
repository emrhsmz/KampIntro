using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Gün Ödevi

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(155, "Emrah");
            Console.WriteLine(dictionary.Length);
            dictionary.Add(255, "Murat");
            Console.WriteLine(dictionary.Length);
            dictionary.Add(355, "Engin");
            Console.WriteLine(dictionary.Length);

            dictionary.Listeleme();
        }
    }
}
