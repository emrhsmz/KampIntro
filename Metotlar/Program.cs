using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;
            urun1.stokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Portakal";
            urun2.Aciklama = "Silifke ürünü";
            urun2.Fiyati = 20;
            urun2.stokAdedi = 20;

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Şeftali";
            urun3.Aciklama = "Şeftali Açıklaması";
            urun3.Fiyati = 25.55;
            urun3.stokAdedi = 25;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            // type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------Metotlar--------------------");
            //instance - örnek
            //encapsulation => bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır.  sayesinde nesneler bilinçsiz kullanımdan korunmuş olur
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            // 
            sepetManager.Ekle2("Armut","Yeşl Armut",35.5,10);
            sepetManager.Ekle2("Mandaline","Sulu Mandalina",45.5,13);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",15.5,8);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice