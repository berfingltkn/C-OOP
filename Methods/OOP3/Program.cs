using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //yukarıdaki şekilde de çalışır, aşağıdaki şekilde de çalışır.

            //Demekki Interface ler de  o interface i implemente eden classın referans numarasını tutabiliyormuş.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //************************************************************************

            //Aşağı kısım çok önemlii. Kredi türleri (tasit, ihtiyac, konut) IKrediManager dan kalıtıldığı için
            //BasvuruManager kısmında tanımlanmış olan methodun parametresi olan IKrediManager a bu uc krediden birini yazabiliriz.
            //Çünkü bunlar IkrediManager dan kalıtılmıştır.

          // Bu bilgi mülakatlarda çok fazla soruluyor. 
            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(ihtiyacKrediManager);

            List<IKrediManager> a = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            List<IKrediManager> b = new List<IKrediManager>() { konutKrediManager };

            basvuruManager.GeciciKrediSorgulama(a);
            basvuruManager.GeciciKrediSorgulama(b);

            Console.WriteLine("*********************************");
            basvuruManager.BasvuruYap(konutKrediManager,new DatabaseLoggerService());

        }
    }
}
