using System;

namespace OOPSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Engin";
            gercekMusteri.Soyadi = "Demiroğ";
            gercekMusteri.TcNo = "11111111111";

            //Kodlama.io
            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "123456789";

            // Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();
            // Müşteri sınıfı gerçek ve tüzel müşteri sınıfını (referansını) tutabiliyor.
            musteri = gercekMusteri;
            musteri2 = tuzelMusteri;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri2);
        }
    }
}
