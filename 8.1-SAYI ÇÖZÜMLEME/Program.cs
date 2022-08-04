using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_SAYI_ÇÖZÜMLEME
{
    class Program
    {
        static void Main(string[] args)
        {
            BasamakSayisi();
            Console.ReadLine();
        }
        private static void BasamakSayisi() 
        {
            string cevap;
            do
            {
                double carpim;
                int kalan;
                int[] basamakDizisi = new int[0];
                int sayi;
                bool sayiMi;
                int sayac = 0;
                
                do
                {
                    Console.WriteLine("lütfen bir tamsayı giriniz ");
                    sayiMi = int.TryParse(Console.ReadLine(), out sayi);

                    if (!sayiMi)
                    {
                        Console.WriteLine("Sadece tam sayi girişi yapınız");
                    }

                } while (!sayiMi);

                int orjinalSayi = sayi;
                do
                {
                    kalan = sayi % 10;
                    sayi = sayi / 10;                
                    sayac++;

                    Array.Resize(ref basamakDizisi, basamakDizisi.Length + 1);
                    basamakDizisi[basamakDizisi.Length - 1] = kalan;

                } while (sayi != 0);

                for (int i = 1; i < sayac; i++)
                {
                    carpim = Math.Pow(10, i);
                    basamakDizisi[i] = basamakDizisi[i] *(int)carpim;
                }

                foreach (var item in basamakDizisi)
                {
                    Console.WriteLine(item);
                }
              
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
