using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Otopark_Ücreti_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            OtoparkUcretHesaplama();
            Console.ReadLine();
           
        }

        private static void OtoparkUcretHesaplama() 
        {
          
            int giris;
            float saat;
            float ucret=0;
            bool dogrumu;          
            
            do
            {
                Console.WriteLine("Lütfen araç tipi için aşağıdaki seçeneklerden birini seçiniz");
                Console.WriteLine("Otomobil : 1\nMotosiklet: 2\nMinübüs: 3\nKamyon : 4\nDiğer : 4");
                dogrumu = int.TryParse(Console.ReadLine(), out giris);


                while (giris != 1 && giris != 2 && giris != 3 && giris != 4)
                {
                    Console.Clear();
                    Console.WriteLine("Otomobil : 1\nMotosiklet: 2\nMinübüs: 3\nKamyon : 4\nDiğer : 4");
                    dogrumu = int.TryParse(Console.ReadLine(), out giris);                   
                  
                }
                

            } while (!dogrumu);

            do
            {
                Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
                dogrumu = float.TryParse(Console.ReadLine(), out saat);

                if (saat<0)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                }
                if (!dogrumu)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                }

            } while (!dogrumu);

            switch (giris)
            {
                case 1:
                    if (0<=saat && saat<=2)                
                        ucret = 5;                  
                    if (2 < giris && saat <=6)                   
                        ucret = 10;                   
                    if (6 < giris && saat <= 12)                  
                        ucret = 12;                   
                    if (12 < giris && saat <= 24)                   
                        ucret = 20;                   
                    if (saat>24)
                    {
                        int adet = (int)saat / 24;
                        ucret = 20;

                        for (int i = 0; i < adet-1; i++)
                        {
                            ucret = ucret + 20;
                        }
                    }                 
                    break;

                case 2:
                    if (0 <= saat && saat <= 2)
                        ucret = 0;
                    if (2 < giris && saat <= 6)
                        ucret = 3;
                    if (6 < giris && saat <= 12)
                        ucret = 6;
                    if (12 < giris && saat <= 24)
                        ucret = 12;
                    if (saat > 24)
                    {
                        int adet = (int)saat / 24;
                        ucret = 12;

                        for (int i = 0; i < adet-1; i++)
                        {
                            ucret = ucret + 10;
                        }
                    }
                    break;

                case 3:
                    if (0 <= saat && saat <= 2)
                        ucret = 8;
                    if (2 < giris && saat <= 6)
                        ucret = 16;
                    if (6 < giris && saat <= 12)
                        ucret = 32;
                    if (12 < giris && saat <= 24)
                        ucret = 45;
                    if (saat > 24)
                    {
                        int adet = (int)saat / 24;
                        ucret = 45;

                        for (int i = 0; i < adet-1; i++)
                        {
                            ucret = ucret + 25;
                        }
                    }
                    break;

                case 4:
                    if (0 <= saat && saat <= 2)
                        ucret = 15;
                    if (2 < giris && saat <= 6)
                        ucret = 30;
                    if (6 < giris && saat <= 12)
                        ucret = 60;
                    if (12 < giris && saat <= 24)
                        ucret = 100;
                    if (saat > 24)
                    {
                        int adet = (int)saat / 24;
                        ucret = 100;

                        for (int i = 0; i < adet - 1; i++)
                        {
                            ucret = ucret + 55;
                        }
                    }
                    break;

                   
            }

            Console.WriteLine($"Ödenecek Tutar : {ucret} TL");

        }
    }
}
