using System;

namespace OOPFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 10, UnitsInStock = 50 };

            //PascalCase //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product2);

            Console.WriteLine("");
            productManager.Update(product2);

            // int,double,bool... deger tip
            // diziler, class, abstract class,interface .... referans tip
            // ref out
            Console.WriteLine("");
            productManager.Topla2(4, 5);
            int toplamaSonucu = productManager.Topla(4, 5);
            Console.WriteLine(toplamaSonucu * 2);
        }
    }
}
