using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2131
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgilendirme();
            Rezervasyon(Secenekler(), BosKoltuklarEco(), BosKoltuklarBusiness());
            Console.ReadLine();
        }
        static void Bilgilendirme()
        {
            Console.WriteLine("***************HOŞGELDİNİZ***************");
            Console.WriteLine("Bu programda size uçak bileti rezervasyonu yaptırılacaktır");
            Console.WriteLine("***************İYİ GÜNLER DİLERİZ***************");
        }
        static string Secenekler()
        {
            string secenek = string.Empty;
            do
            {
                Console.WriteLine("Business Class bölümü için 1 tuşuna basın / Economy Class bölümü için 2 tuşuna basın ");
                secenek = Console.ReadLine();
                while (secenek != "1" && secenek != "2")
                {
                    Console.Clear();
                    Bilgilendirme();
                    Console.WriteLine("Business Class bölümü için 1 tuşuna basın / Economy Class bölümü için 2 tuşuna basın ");
                    secenek = Console.ReadLine();

                }
            } while (secenek != "1" && secenek != "2");

            return secenek;
        }
        static int[] BosKoltuklarEco()
        {
            int[] business = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] economy = { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] economyBos = { 9, 12, 13, 19, 20 };

            return economyBos;

        }
        static int[] BosKoltuklarBusiness()
        {
            int[] businessBos = { 1, 2, 3, 4, 5, 6, 7, 8 };

            return businessBos;

        }

        static void Rezervasyon(string secenek, int[] economyBos, int[] businessBos)
        {
            string cevap = string.Empty;
            string devamEtmeDurumu = string.Empty;
            if (secenek == "2")
            {
               // for (int i = 0; i < 5; i++)
              //  {
                    Console.WriteLine($"Boş koltuklardan birini seçiniz.");
                    foreach (int item in economyBos)
                    {
                        Console.WriteLine(item);
                    }
                    int secilenKoltukNo = Convert.ToInt32(Console.ReadLine());

                    switch (secilenKoltukNo)
                    {
                        case 9:
                            Array.Clear(economyBos, 0, 0);
                            Array.Sort(economyBos);
                            Array.Resize(ref economyBos, economyBos.Length - 1);
                            break;
                        case 12:
                            Array.Clear(economyBos, 1, 0);
                            Array.Sort(economyBos);
                            Array.Resize(ref economyBos, economyBos.Length - 1);
                            break;
                        case 13:
                            Array.Clear(economyBos, 2, 0);
                            Array.Sort(economyBos);
                            Array.Resize(ref economyBos, economyBos.Length - 1);
                            break;
                        case 19:
                            Array.Clear(economyBos, 3, 0);
                            Array.Sort(economyBos);
                            Array.Resize(ref economyBos, economyBos.Length - 1);
                            break;
                        case 20:
                            Array.Clear(economyBos, 4, 0);
                            Array.Sort(economyBos);
                            Array.Resize(ref economyBos, economyBos.Length - 1);
                            break;
                    }
                    Console.WriteLine("Lüften Adınızı Soyadınızı Giriniz");
                    string yolcuBilgisi = Console.ReadLine();
                    Console.WriteLine($"Economy Class bölümündeki {secilenKoltukNo} numaralı koltuk {yolcuBilgisi} yolcuya rezerve edilmiştir.");

                    Console.WriteLine("bilet almaya devam mı? ");
                    devamEtmeDurumu = Console.ReadLine();                 
                 

               // }

                 Secenekler();

                

               // Console.WriteLine("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır. Business Class bölümündeki boş koltukları görmek ister misiniz? E/H");
              //  cevap = Console.ReadLine();
            }

            else if (secenek == "1" || (cevap == "E" || cevap == "e"))
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine($"Boş koltuklardan birini seçiniz.");
                    foreach (int item in businessBos)
                    {
                        Console.WriteLine(item);
                    }
                    int secilenKoltukNo = Convert.ToInt32(Console.ReadLine());

                    switch (secilenKoltukNo)
                    {
                        case 1:
                            Array.Clear(businessBos, 0, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 2:
                            Array.Clear(businessBos, 1, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 3:
                            Array.Clear(businessBos, 2, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 4:
                            Array.Clear(businessBos, 3, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 5:
                            Array.Clear(businessBos, 4, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 6:
                            Array.Clear(businessBos, 5, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 7:
                            Array.Clear(businessBos, 6, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                        case 8:
                            Array.Clear(businessBos, 7, 0);
                            Array.Sort(businessBos);
                            Array.Resize(ref businessBos, businessBos.Length - 1);
                            break;
                    }
                    Console.WriteLine("Lüften Adınızı Soyadınızı Giriniz");
                    string yolcuBilgisi = Console.ReadLine();
                    Console.WriteLine($"Business Class bölümündeki {secilenKoltukNo} numaralı koltuk {yolcuBilgisi} yolcuya rezerve edilmiştir.");

                    Console.WriteLine("bilet almaya devam mı? ");
                    devamEtmeDurumu = Console.ReadLine();

                    Secenekler();

                }
                Console.WriteLine("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır. Economy Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                cevap = Console.ReadLine();

            }

            else if (cevap == "H" || cevap == "h")
            {
                Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
            }

        }

    }
}
