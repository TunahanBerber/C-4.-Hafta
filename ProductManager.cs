using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)  //Void emir gibi bir şeydir git getir der return etmene gerek yok. eğer metod sonucu devamında lazımsa void onu yapmaz return ile değeri alırsın ama void görevi yapar işini bititir.
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
    }
}
