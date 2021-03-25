using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            //int,decimal,float,double,bool => değer tip
            //array, class, interface => referans tip

            // bellekte değer tipler stack saklanır
            // stack        // heap
            //-------------------------
            // sayi1=10  |    
            // sayi2=30  |

            // bellkete referanslar heap de saklanır. 
            // kullanılmayan referans tipleri bir süre sonra bellekten silinir.
            // stack        // heap
            //-------------------------
            // sayilar1  |   [0,1,2,3]
            // sayilar2  |   [100,200,300]
        }
    }
}
