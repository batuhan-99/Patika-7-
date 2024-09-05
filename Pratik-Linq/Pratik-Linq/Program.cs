using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> sayi = Enumerable.Range(1, 10).Select(x => rand.Next(-50, 50)).ToList();
            //Çift sayıları bulma
            Console.WriteLine("Çift sayılar:");
            var evenNumbers = sayi.Where(x => x % 2 == 0).ToList();
            foreach(var i in evenNumbers)
            {
                Console.Write(i + ",");
            }
            //Tek sayıları bulma
            Console.WriteLine();
            Console.WriteLine("Tek sayılar:");
            var oddNumbers = sayi.Where(x => x % 2 != 0 ).ToList();
            foreach(var i in oddNumbers)
            {
                Console.Write(i + ",");
            }
            //Pozitif sayılar 
            Console.WriteLine();
            Console.WriteLine("Pozitif sayılar:");
            var positive = sayi.Where(x => x>0).ToList();
            
            foreach (var i in positive)
            {
                Console.Write(i + ",");
            }
            //Negatif sayılar
            Console.WriteLine();
            Console.WriteLine("Negatif sayılar:");
            var negative = sayi.Where(x => x<0).ToList();
            foreach (var i in negative)
            {
                Console.Write(i +",");
            }
            //15'ten büyük ve 22'den küçük sayılar
            Console.WriteLine();
            Console.WriteLine("15'ten büyük ve 22'den küçük sayılar");
            var between = sayi.Where(x => x > 15 && x < 22).ToList();
            foreach (var i in between)
            {
                Console.Write(i + ",");
            }

            //Sayıların karesi
            Console.WriteLine();
            Console.WriteLine("Sayıların karesi:");
            var square = sayi.Select(x => x * x).ToList();
            foreach (var i in square)
            {
                Console.Write(i + ",");
            }


        }
    }
}