using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_uygulaması
{
    public class kullanici
    {
        public  string Isim { get; set; }
        public  string Soyisim { get; set; }
        public  int Sifre { get; set; }
        public  int Bakiye { get; set; }
        public int borc { get; set; }
        private  int basarisizgiris { get; set; }
        public kullanici(string isim, string soyisim, int sifre, int bakiye, int borc)
        {
            Isim = isim;
            Soyisim = soyisim;
            Sifre = sifre;
            Bakiye = bakiye;
            this.borc = borc;
        }
        public static void MusteriEkle(List<kullanici> musteri, string isim, string soyisim, int sifre, int bakiye,int borc)
        {
            kullanici yeniMusteri = new kullanici(isim, soyisim, sifre, bakiye,borc);
            musteri.Add(yeniMusteri);
        }
        public static kullanici KullaniciGiris(List<kullanici> musteri, int girilenSifre)
        {
            // Girilen şifreyi kullanıcı listesinde ara
            foreach (var k in musteri)
            {
                if (k.Sifre == girilenSifre)
                {
                    return k; 
                }
            }

            return null; 
        }
        public static void basarisizgirisler(int sifre, DateTime date)
        {
            System.IO.File.AppendAllText("Basarisiz Girişler.txt", $"Girilen Şifre: {sifre} {date}\n");
            if (sifre == 0)
            {
                Console.WriteLine($"Girilen Şifre: {sifre} {date}");
            }
        }

    }
}
