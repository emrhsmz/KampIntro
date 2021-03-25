using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFirst
{
    class Product
    {
        // snippet => hazır kodlar tab tab basılırsa property eklenir
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
