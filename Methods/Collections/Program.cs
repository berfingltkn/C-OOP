using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //diyelim ki isimler isminde bir array imiz olsun ve eleman sayısı 4 olsun.
            //Biz bu array e 5. elemanı eklemek istediğimizde sıkıntı çıkarır. Bu yüzden koleksiyonları kullanırız.
            //Örneğin list, stack, queue vb.

            //string[] isimler = new string[] { "Berfin", "Figen", "Mina", "Kava", "Osman" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Ctrl+k ctrl+c ile seçtiğin tüm textleri command satırına alabilirsin.

            //bu array e bir eleman daha eklemek istersek ve aşağıdaki gibi yaparsak,
            //isimler[4] elemanını ekrana yazdırır fakat bu sefer diğer elemanları yazdırmak istediğimizde null olarak gösterir.

            //isimler = new string[5];
            //isimler[4] = "Umut";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Berfin","Figen","Mina","Kava","Osman"};
            // OR isimler2. Add("Berfin");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("berfin2");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
