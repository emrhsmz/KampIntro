using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3. Gün Ödevi

            Console.WriteLine("Müşteri Bilgileri Sistemi");
            Console.WriteLine("-----------------------------");

            Customer customer1 = new Customer { Id = 1, FirstName = "Emrah", LastName = "Semiz", TCNumber = 11111111111, Age = 30, Gender = "Erkek", Balance = 255.00 };
            Customer customer2 = new Customer { Id = 2, FirstName = "Emrah", LastName = "Semiz", TCNumber = 11111111111, Age = 30, Gender = "Erkek", Balance = 300.00 };
            Customer customer3 = new Customer { Id = 3, FirstName = "Emrah", LastName = "Semiz", TCNumber = 11111111111, Age = 30, Gender = "Erkek", Balance = 000.00 };
            
            Console.WriteLine(" ");
            Console.WriteLine("Müşteriler Eklenmeye Başladı");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine(" ");
            Console.WriteLine("Müşteriler");
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.AllList(customers);

            Console.WriteLine(" ");
            Console.WriteLine("Müşteri Silindi");
            customerManager.Delete(customer2);

        }
    }
}
