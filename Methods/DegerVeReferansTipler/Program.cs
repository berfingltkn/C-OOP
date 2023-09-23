using OOP1;
using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

           Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 1500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2,CategoryID=5,
            UnitInStock=5,ProductName="Pencil",UnitPrice=35};

            //PascalCase  camelCase
            //case sensitive

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);

        }
    }
}
