using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //Manager,serice,controller gibi isimlendirme varsa o ürün ile ilgili operasyonları içerir.
    
    public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");


        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }
    }
}
