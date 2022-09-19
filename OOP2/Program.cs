using OOP2;
using System.Collections.Generic;

//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

//TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();
//taşıtKrediManager.Hesapla();

//KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

//bu şekilde de yapabiliyoruz. İnterfaceler o interface i implemente eden classın referans numarasını tutabiliyoruz. 

IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
IKrediManager tasitKrediManager1 = new TasitKrediManager();
IKrediManager konutKrediManager1 = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();


BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager1,fileLoggerService);



List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager1, konutKrediManager1 };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);