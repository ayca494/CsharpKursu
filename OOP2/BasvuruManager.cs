using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //bilgileri değenledirme 

            //kredi hesaplama 
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); //bu şekilde yaparsan basvuruYap konutkredisine bağımlı hale gelir

            //Ben başvuru yaparken parametre alıp hangi krediye göre yapmam gerektiğini söyle desem 
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
