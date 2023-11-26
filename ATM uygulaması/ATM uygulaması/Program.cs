using ATM_uygulaması;

Console.WriteLine("***************************");
Console.WriteLine("X BANK ATM SİNE HOŞGELDİNİZ");
Console.WriteLine("***************************");
Console.Write("LÜTFEN ŞİFRENİZİ GİRİNİZ: ");
List<kullanici> musteriListesi = new List<kullanici>();

kullanici.MusteriEkle(musteriListesi, "Hasan", "Torlak", 159951, 2000,500);
kullanici.MusteriEkle(musteriListesi, "Tuğkan", "Arslan", 123453, 3000, 2200);
kullanici.MusteriEkle(musteriListesi, "Elif", "Toker", 555218, 4000, 520);
kullanici.MusteriEkle(musteriListesi, "Ayşe", "Gül", 000152, 5000, 980);
//Admin
kullanici.MusteriEkle(musteriListesi, "Oğuzhan", "Topal", 000000, 0000, 000);

int sifre = Convert.ToInt32(Console.ReadLine());

kullanici girisYapanKullanici = kullanici.KullaniciGiris(musteriListesi, sifre);
int sayac = 1;
while (sayac == 1)
{
    if (girisYapanKullanici != null)
    {
        Console.WriteLine("Giriş başarılı!");
        Console.WriteLine($"Hoşgeldiniz, {girisYapanKullanici.Isim} {girisYapanKullanici.Soyisim}");
        if (girisYapanKullanici.Sifre == 0000)
        {

            Console.WriteLine("Admin Hoşgeldin...");
            Console.WriteLine("işte loglar...");
            kullanici.basarisizgirisler(0, DateTime.Now);
            break;
        }
        Console.WriteLine("{1} PARA YATIRMA");
        Console.WriteLine("{2} PARA ÇEKME");
        Console.WriteLine("{3} BORÇ ÖDEME");
        Console.WriteLine("{4} KARTINIZI GERİ ALMAK İÇİN");
        Console.Write("Lütfen Yapmak İstediğiniz İşlemi seçin: ");
        int islem = Convert.ToInt32(Console.ReadLine());

        switch (islem)
        {


            case 1:
                Console.WriteLine("Toplam Bakiyeniz: " + girisYapanKullanici.Bakiye);
                Console.Write("Eklemek İstediğiniz tutar?: ");
                int tutar = Convert.ToInt32(Console.ReadLine());
                int b = girisYapanKullanici.Bakiye + tutar;
                Console.WriteLine("Yeni Bakiyeniz: " + b);
                break;
            case 2:
                Console.WriteLine("Toplam Bakiyeniz: " + girisYapanKullanici.Bakiye);
                Console.Write("Çekmek İstediğiniz tutar?: ");
                int tutar1 = Convert.ToInt32(Console.ReadLine());
                int a = girisYapanKullanici.Bakiye - tutar1;
                Console.WriteLine("Yeni Bakiyeniz: " + a);
                break;
            case 3:
                Console.WriteLine("Toplam Bakiyeniz: " + girisYapanKullanici.Bakiye);
                Console.WriteLine("Toplam Borcunuz: " + girisYapanKullanici.borc);
                Console.Write("Ödemek İstediğiniz tutar: ");
                int tutar2 = Convert.ToInt32(Console.ReadLine());
                int c = girisYapanKullanici.Bakiye - tutar2;
                int borc = c - girisYapanKullanici.borc;
                Console.WriteLine("Yeni Bakiyeniz: " + c);
                Console.WriteLine("Kalan Borcunuz: " + borc);
                break;
            case 4:
                Console.WriteLine("Başarılı bir şekilde çıkış yapıldı...");
                sayac++;
                break;
            default:
                Console.WriteLine("Geçersiz Seçin Lütfen Tekrar Seçin...");
                break;

        }
    }
    else
    {
        Console.WriteLine("Şifre hatalı!");
        kullanici.basarisizgirisler(sifre, DateTime.Now);
        break;
    }
}