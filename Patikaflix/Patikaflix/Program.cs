using System;
using System.Security.Cryptography.X509Certificates;

namespace Patikaflix
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Dizi> diziler = new List<Dizi> ();
            string devam;
            do
            {
                Console.WriteLine("Dizi adı giriniz:");
                string ad = Console.ReadLine();

                Console.WriteLine("Yapım yılı giriniz:");
                int yapimYili = int.Parse(Console.ReadLine());

                Console.WriteLine("Dizi türü giriniz:");
                string tur = Console.ReadLine();

                Console.WriteLine("Yayınlanmaya başlama yılı giriniz:");
                int baslamaYili = int.Parse(Console.ReadLine());

                Console.WriteLine("Yönetmen giriniz:");
                string yonetmen = Console.ReadLine();

                Console.WriteLine("Yayınlandığı ilk platform giriniz:");
                string platform = Console.ReadLine();

                diziler.Add(new Dizi
                {
                    Ad = ad,
                    YapimYili = yapimYili,
                    Tur = tur,
                    YayinaBaslamaYili = baslamaYili,
                    Yonetmen = yonetmen,
                    IlkPlatform = platform
                });

                Console.WriteLine("Yeni bir dizi eklemek istiyor musunuz? (e/h):");
                devam = Console.ReadLine().ToLower();

            } while (devam == "e");

            var komediDizileri = diziler.Where(x => x.Tur.ToLower().Contains("komedi"))
                .Select(x => new KomediDizisi
                {
                    Ad = x.Ad,
                    Tur = x.Tur,
                    Yonetmen = x.Yonetmen
                })
            .OrderBy(x => x.Ad)
            .ThenBy(x => x.Yonetmen)
            .ToList();
            Console.WriteLine("\nKomedi Dizileri:");
            foreach (var dizi in komediDizileri)
            {
                Console.WriteLine($"Ad: {dizi.Ad}, Tür: {dizi.Tur}, Yönetmen: {dizi.Yonetmen}");
            }
        }
    }
}