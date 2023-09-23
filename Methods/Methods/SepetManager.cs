using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        // Genelde isimlerde Manager, Controller gibi yapılar varsa bu bir operasyon tutuyor demektir.
        //Yani ortak kodlar vardır. Örneğin sepete ekleme, sepeti görüntüleme vs.
    
    public void Ekle(Product product)
        {
            Console.WriteLine(product.Adi + " Sepete Eklendi. ");

            //1.45 de kaldım

        }

        //Ayrı ayrı aşağıdaki gibi yazmaktansa biz class yapısını kullanırız.
        public void Ekle2(string UrunAdi,string aciklama,double fiyat,int stokAdedi)
        {

            Console.WriteLine("Congratulations, added to cart" + UrunAdi);
        }
    }
}
