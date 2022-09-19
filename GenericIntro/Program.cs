// See https://aka.ms/new-console-template for more information


using GenericIntro;

MyList<string> isimler = new MyList<string>() { };

isimler.Add("Engin");
isimler.Add("Halil");
isimler.Add("Murat");
isimler.Add("İlker");


Console.WriteLine(isimler.Lenght);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}

