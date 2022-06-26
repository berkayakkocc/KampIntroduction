using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//FOREIGN KEY
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//Birim fiyat
        public int UnitsInStock { get; set; }//Stok Adedi

        //Create Read Update Delete-CRUD GENEL METHODLAR


    }
}
