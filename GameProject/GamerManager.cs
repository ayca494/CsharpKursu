using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    //Eğer bir sınıfın içerisinde başka bir manager sınıfı kullanacaksan asla new leme ctor constructor kullan  
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;
        //gmaer manager içinde bir bağımlılığım var bir doğrulama servisi kullanacağım demek 
        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
