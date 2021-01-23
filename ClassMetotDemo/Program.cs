using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Mert";
            musteri1.Id = "1";
            musteri1.Soyad = "Demir";
            musteri1.Bakiye = 0;
            musteri1.HesapNo = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ali";
            musteri2.Id = "2";
            musteri2.Soyad = "Saydam";
            musteri2.Bakiye = 10000;
            musteri2.HesapNo = 12343;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Id = "3";
            musteri3.Soyad = "Caliskan";
            musteri3.Bakiye = 999;
            musteri3.HesapNo = 12342;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("----------------------------");

            musteriManager.Delete(musteri2);

            Console.WriteLine("----------------------------");

            musteriManager.BakiyeEkle(musteri1, 993);
            Console.WriteLine(musteri1.Bakiye);

            musteriManager.Listele(musteriler);

            Console.WriteLine("----------------------------");
        }
    }
}
