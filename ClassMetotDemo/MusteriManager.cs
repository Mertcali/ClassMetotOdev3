using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad + "  "  +  musteri.HesapNo + "  Hesap  numarası ile eklendi"  );
        }

        public void BakiyeEkle(Musteri musteri, int bakiye)
        {
            Console.WriteLine(musteri.HesapNo + " 'lu hesap numarasına" +"  "+ musteri.Ad + " " + musteri.Soyad  +  " adına "  +bakiye +  "  TL eklendi "  );
            musteri.Bakiye += bakiye;
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad + "  " + musteri.HesapNo + "  Hesap  numarası ile silindi");
        }

        public void Listele(Musteri[] musteriliste)
        {
            foreach (var musteri in musteriliste)
            {
                Console.WriteLine("Musteri Id:" +musteri.Id);
                Console.WriteLine("Musteri Adı:" +musteri.Ad);
                Console.WriteLine("Musteri Soyadı:" +musteri.Soyad);
                Console.WriteLine("Musteri Hesap No:" +musteri.HesapNo);
                Console.WriteLine("Musteri Bakiye:" +musteri.Bakiye);
                Console.WriteLine("-----------");
            }
        }
    }
}
