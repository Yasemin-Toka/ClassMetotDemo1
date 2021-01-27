using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Alaaddin";
            musteri1.Soyadi = "Keykubat";
            musteri1.TcKimlikNo = "00000678900";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "1.Murat";
            musteri2.Soyadi = "Osman";
            musteri2.TcKimlikNo = "00000066900";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "2. Mehmet";
            musteri3.Soyadi = "Osmanlıtorunu";
            musteri3.TcKimlikNo = "00005678900";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "5. Mehmet";
            musteri4.Soyadi = "Osmanlı";
            musteri4.TcKimlikNo = "01005678900";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Guncelle(musteri3);
            musteriManager.Sil(musteri4);


        }
    }
}
