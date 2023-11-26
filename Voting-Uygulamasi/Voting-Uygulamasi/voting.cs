using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class voting
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Yetki { get; set; }
        public int oymiktari { get; set; }
        public void ekle(List<voting> kullanicilar, int id, string isim, string soyisim, string yetki)
        {
            voting yeniKullanici = new voting { Id = id, Isim = isim, Soyisim = soyisim, Yetki = yetki };
            kullanicilar.Add(yeniKullanici);
        }
        public void yazdir(List<voting> kullanicilar)
        {
            Console.WriteLine("Kullanıcılar:");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine($"ID: {kullanici.Id}, İsim: {kullanici.Isim}, Soyisim: {kullanici.Soyisim}, Yetki: {kullanici.Yetki}");
            }
            Console.WriteLine();
        }
        public void sil(List<voting> kullanicilar, int id)
        {
            voting silinecek = kullanicilar.Find(x => x.Id == id);
            if (silinecek != null)
            {
                kullanicilar.Remove(silinecek);
            }
        }
        public void ara(List<voting> kullanicilar, string isim)
        {
            voting ara = kullanicilar.Find(x => x.Isim == isim);
            if (ara != null)
            {
                Console.WriteLine($"ID: {ara.Id}, İsim: {ara.Isim}, Soyisim: {ara.Soyisim}, Yetki: {ara.Yetki}");
            }
            else
            {
                Console.WriteLine("Girmiş Olduğunuz isimde biri bulunmamakta Lütfen yeni bir üyelik oluşturun.");
            }
        }
        public void oymiktarlari(int a)
        {
            if (a == 1)
            {
                oymiktari = 20;
                Console.WriteLine("Toplam oy miktarı = " + oymiktari);
                Console.WriteLine("Sizin oyunuz ile birlikte: " + Convert.ToInt32(oymiktari) + 1 +" " + "Yüzde: " + oymiktari % 100);
            }
            else if (a == 2)
            {
                oymiktari = 30;
                Console.WriteLine("Toplam oy miktarı = " + oymiktari);
                Console.WriteLine("Sizin oyunuz ile birlikte: " + Convert.ToInt32(oymiktari) + 1 + " " + "Yüzde: " + Convert.ToInt32(oymiktari) % 100);
            }
            else if (a ==3)
            {
                oymiktari = 40;
                Console.WriteLine("Toplam oy miktarı = " + oymiktari);
                Console.WriteLine("Sizin oyunuz ile birlikte: " + Convert.ToInt32(oymiktari) + 1 + " " + "Yüzde: " + Convert.ToInt32(oymiktari) % 100);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz...");
            }
        }
        public void tumoylar()
        {
            Console.WriteLine("Film Oy miktari : 20");
            Console.WriteLine("Tech Stack Oy miktari : 30");
            Console.WriteLine("Spor Oy miktari : 40");
        }
        public void baslangic()
        {
            Console.WriteLine("Merhaba, İşte Kategoriler!");
            Console.WriteLine("Film Kategorileri");
            Console.WriteLine("Tech Stack");
            Console.WriteLine("Spor");
            Console.WriteLine("Eğer yeni bir Kategori veya filmin eklenmesini isterseniz OY vermelisiniz.");
            Console.WriteLine("Üyeliğiniz var ise {1} Üyelik Açmak istiyorsanız {2} yi seçiniz.");
            Console.Write("Lütfen değer giriniz: ");

        }
    }
}
