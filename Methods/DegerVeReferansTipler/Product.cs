using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {

        //CRUD- ekleme,silme gibi işlemlerin genel ismi(create-read-update-delete)

        public int Id { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }//birim fiyat
        public int UnitInStock { get; set; }

    }
}
