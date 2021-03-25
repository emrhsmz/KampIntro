using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım kuralları
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! Eklenen Ürün : " + urun.Adi);
            //
            //
            //
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi! Eklenen Ürün : " + urunAdi);
        }
    }
}