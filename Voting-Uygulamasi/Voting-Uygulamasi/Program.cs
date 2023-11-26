using Voting_Uygulamasi;

List<voting > votings = new List<voting>();
voting oy = new voting();
oy.ekle(votings, 1, "Ahmet", "Sercan", "Üye");
oy.ekle(votings, 2, "Elif", "Gülmez", "Admin");
oy.ekle(votings, 3, "Hüseyin", "Yaraf", "Üye");

oy.baslangic();

int a = Convert.ToInt32(Console.ReadLine());


while (a == 1)
{
    Console.Write("Lütfen İsminizi giriniz: Çıkış yapmak için {2}: ");
    string isim = Console.ReadLine();
    oy.ara(votings, isim);
    if (isim == "2")
    {
        break;
    }
    Console.WriteLine("Tebrikler Artık Oy verebilirsiniz Lütfen Oy vermek istediğiniz kategoriyi seçiniz.");
    Console.WriteLine("{1} Film Kategorileri");
    Console.WriteLine("{2} Tech Stack");
    Console.WriteLine("{3} Spor");
    Console.WriteLine("Bu kategorilerden hangsine oy vermek istiyorsunuz?");
    int c = Convert.ToInt32(Console.ReadLine());

    oy.oymiktarlari(c);
}

if (a == 2)
{
       Console.Write("Lütfen id giriniz : ");
       int id = Convert.ToInt32(Console.ReadLine());
       Console.Write("Lütfen İsim giriniz : ");
       string deger1 = Console.ReadLine();
       Console.Write("Lütfen Soyisim giriniz : ");
       string deger2 = Console.ReadLine();
       oy.ekle(votings, id, deger1, deger2, "Üye");
       oy.yazdir(votings);
    Console.WriteLine("Tebrikler Artık Oy verebilirsiniz Lütfen Oy vermek istediğiniz kategoriyi seçiniz.");
    Console.WriteLine("{1} Film Kategorileri");
    Console.WriteLine("{2} Tech Stack");
    Console.WriteLine("{3} Spor");
    Console.WriteLine("Bu kategorilerden hangsine oy vermek istiyorsunuz?");
    int c = Convert.ToInt32(Console.ReadLine());

    oy.oymiktarlari(c);

}


