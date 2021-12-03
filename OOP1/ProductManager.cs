using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Ürününüz Eklendi : " + product.ProductName);
        }


        public void BiseyYap(int sayi) 
        {
            sayi = 99;
        }
    }
}
