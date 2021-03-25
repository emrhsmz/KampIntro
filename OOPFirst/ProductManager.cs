using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFirst
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            product.ProductName = "Kamera"; 
            Console.WriteLine("Ürün Adı " + product.ProductName + " olarak güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
