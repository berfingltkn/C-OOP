using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product();

            p1.Adi = "Elma";
            p1.Fiyati = 10;
            p1.Aciklamasi = "Amasya Elmasi";

            p2.Adi = "Karpuz";
            p2.Fiyati = 15;
            p2.Aciklamasi = "Diyarbakir Karpuzu";

            Product[] fruit = new Product[] {p1,p2 };
            
            foreach(Product x in fruit)
            {
                Console.WriteLine(x.Adi);//Writeline programcının bir aracıdır.
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklamasi);
                Console.WriteLine("----------------");
            }

            SepetManager sepet = new SepetManager();
            sepet.Ekle(p1);
            sepet.Ekle(p2);

            sepet.Ekle2("Armut","Yesil Armut",12,10);
            sepet.Ekle2("Elma", "Yesil Elma", 12, 9);
            sepet.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 10);
        }
    }
}
