using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Adi = "Nur Sultan";
            musteri1.Soyadi = "Dinç";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demirog";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Adi = "Nur ";
            musteri3.Soyadi = "Sultan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("**********");
            }

            //Metotlar

            Console.WriteLine("++++++EKLENDİ++++++++");
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine();

            Console.WriteLine("///////LİSTELENDİ////////");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine();

            Console.WriteLine("-----SİLİNDİ----");

            musteriManager.Silme(musteri3);



        }
    }
}
