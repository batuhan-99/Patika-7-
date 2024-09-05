using System;
using System.Collections.Generic;
using System.Linq;
namespace Patikafy_Müzik_Platformu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<sarkici> sanatci = new List<sarkici>
            {
            new sarkici { AdSoyad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatis = 20 },
            new sarkici { AdSoyad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatis = 10 },
            new sarkici { AdSoyad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 3 },
            new sarkici { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 5 },
            new sarkici { AdSoyad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatis = 3 },
            new sarkici { AdSoyad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 10 },
            new sarkici { AdSoyad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatis = 40 },
            new sarkici { AdSoyad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 7 },
            new sarkici { AdSoyad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatis = 5 },
            new sarkici { AdSoyad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatis = 10 },
            new sarkici { AdSoyad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatis = 2 }

            };
            //S ile başlayanlar
            var isim = sanatci.Where(x => x.AdSoyad.StartsWith("S")).ToList();
            Console.WriteLine("S ile başlayan sanatçılar:");
            foreach (var s in isim)
                Console.Write(s.AdSoyad + ",");

            //Album satislari 10 milyon üzerinde olanlar
            Console.WriteLine();
            Console.WriteLine("Albüm satışları yüksek olanlar:");
            var satis = sanatci.Where(x => x.AlbumSatis > 10).ToList();
            foreach (var s in satis)
            {
                Console.Write(s.AdSoyad + ",");
            }

            //2000 yılı öncesi çıkmış sanatçılar
            Console.WriteLine();
            Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
            var popsarkici = sanatci.Where(x => x.CikisYili < 2000 && x.MuzikTuru.Contains("Pop"))
                .OrderBy(x => x.CikisYili)
                .ThenBy(x => x.AdSoyad)
                .ToList();
           popsarkici.ForEach(s => Console.WriteLine($"{s.CikisYili} - {s.AdSoyad}"));


            //En çok albüm satan sanatçı
            Console.WriteLine();
            var encok = sanatci.OrderByDescending(s => s.AlbumSatis).FirstOrDefault();
            Console.WriteLine($"\nEn çok albüm satan şarkıcı: {encok.AdSoyad}");

            //En yeni ve en eski çıkış yağan sanatçılar
            Console.WriteLine();
            var yenicikan=sanatci.OrderByDescending(s=>s.CikisYili).FirstOrDefault();
            var eskicikan = sanatci.OrderBy(s => s.CikisYili).FirstOrDefault();
            Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {yenicikan.AdSoyad}");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {eskicikan.AdSoyad}");
        }
    }
}