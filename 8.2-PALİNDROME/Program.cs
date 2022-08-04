using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_PALİNDROME
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome();
            Console.ReadLine();
        }

        private static void Palindrome()
        {
            string cevap;
            do
            {
                int sayi;
                bool sayiMi;
                int orjinalSayi;
                int sayac=0;
                int[] dizi = new int[0];

                do
                {
                    Console.WriteLine("lütfen bir sayı giriniz ");
                    sayiMi = int.TryParse(Console.ReadLine(), out sayi);

                    if (!sayiMi)
                    {
                        Console.WriteLine("Sadece tam sayi girişi yapınız");
                    }

                } while (!sayiMi);

                orjinalSayi = sayi;
                
                do
                {
                    Array.Resize(ref dizi, dizi.Length + 1);
                    dizi[dizi.Length - 1] = sayi % 10;
                    sayi = sayi / 10;

                } while (sayi != 0);

                for (int i = 0; i < dizi.Length/2; i++)
                {
                    if (dizi[i] == dizi[dizi.Length-(i+1)])
                    {
                        sayac++;
                        continue;

                    }

                }

                if (dizi.Length / 2 == sayac)              
                    Console.WriteLine($"{orjinalSayi} sayısı bir 'POLİDROME' sayıdır.");
                
                else              
                    Console.WriteLine($"{orjinalSayi} sayısı bir 'POLİDROME' sayı değildir.");
                

                Console.WriteLine("Çıkış yapmak için lütfen (Exit) komutunu kullanınız ");
                cevap = Console.ReadLine();

                if (cevap == "Exit")
                {
                    Environment.Exit(0);
                }

            } while (cevap != "Exit");
        }
    }
}
