using System;

namespace HomeworkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odev: Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz.
            //Yeni üye, satış ve kampanya yönetimi yapılması isteniyor.
            //Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği,
            //kayıtlarını silebileceği bir ortamı simule ediniz.
            //Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E - devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)

            Console.WriteLine("how can!");


            Gamer _gamer = new Gamer();

            _gamer.ID = 10;
            _gamer.Name = "Berfin";
            _gamer.Surname = "Gultekin";
            _gamer.DateTime =2002;

            UserValidationManager _userValidation = new UserValidationManager();
            GamerManager _gamerManager = new GamerManager(_userValidation);
            _gamerManager.Added(_gamer);

        }
    }
}
