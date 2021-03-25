using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.TCNumber + " TC Kimlik Nolu " + customer.FirstName + " " + customer.LastName + " hesap bilgisi oluşturulmuştur.");
        }

        public void AllList(Customer[] customers)
        {
            foreach (Customer customerItem in customers)
            {
                Console.WriteLine("Adı Soyadı : " + customerItem.FirstName + " " + customerItem.LastName );
                Console.WriteLine("TC Kimlik No : " + customerItem.TCNumber);
                Console.WriteLine("Yaş : " + customerItem.Age);
                Console.WriteLine("Cinsiyeti : " + customerItem.Gender);
                Console.WriteLine("Hesap Bakiyesi : " + customerItem.Balance);
                Console.WriteLine("-------");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.TCNumber +  " TC Kimlik Nolu " + customer.FirstName + " " + customer.LastName + " hesap bilgileri silinmiştir.");
        }
    }
}
