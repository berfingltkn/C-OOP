using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {

      public void BasvuruYap(IKrediManager kredihesapla,ILoggerService loggerService)
        {
            kredihesapla.Hesapla();
            loggerService.Log();
        }

        public void GeciciKrediSorgulama(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
