using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_HAVAYOLLARI_REZERVASYON_SİSTEMİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Acilis();
            EkonomiBusinessSinifi();
            Kapanis();
            Console.ReadLine();
        }

        private static void Acilis()
        {
            Console.WriteLine("\n");
            Console.WriteLine("****************************************");
            Console.WriteLine("    ZORLU HAVA YOLLARINA HOŞGELDİNİZ");
            Console.WriteLine("****************************************");
            Console.WriteLine("\n");

        }
        private static int SınıfSecimi() 
        {
            int giris;
            bool dogrumu;
            
            do
            {
                Console.WriteLine("Economy Class için 1 tuşuna basınız\nBusiness Class için 2 tuşuna basınız");
                dogrumu = int.TryParse(Console.ReadLine(), out giris);

                while (giris != 1 && giris != 2 &&  giris <= 0)
                {

                    Console.Clear();
                    Console.WriteLine("Hatalı giriş yaptınız\nEconomy Class için 1 tuşuna basınız\nBusiness Class için 2 tuşuna basınız");
                    dogrumu = int.TryParse(Console.ReadLine(), out giris);

                }

            } while (!dogrumu);

            Console.Clear();
            return giris;
        }

        private static void EkonomiBusinessSinifi() 
        {
            
                
            int[] ekonomi = { 9, 12, 13, 19, 20 };
            int[] business = { 3, 4, 6, 7 };
            int[] secilenKoltuk = new int[0];
            string[] name = new string[0];
            int koltuk;       
            bool dogrumu;
            string cevap = string.Empty;
            string gelenCevap = string.Empty;
            int sinifSecimi;
                   
            do
            {
               sinifSecimi = SınıfSecimi();


                Array.Resize(ref name, name.Length + 1);

                if (sinifSecimi == 1)
                {
                    if (ekonomi.Length != 0)
                    {
                        do
                        {
                            Console.WriteLine("Ekonomi sınıfı için için boş koltuk numaraları aşağıdaki gibidir. Lütfen seçiniz\n");
                            
                            foreach (var item in ekonomi)                           
                                Console.Write($" *{item}\n");
                            
                            dogrumu = int.TryParse(Console.ReadLine(), out koltuk);

                            if (koltuk <= 0)
                            {
                              
                                Console.WriteLine("Hatalı birr koltuk seçimi yyaptıınız");
                                dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                            }

                            if (koltuk != 9 && koltuk != 12 && koltuk != 13 && koltuk != 19 && koltuk != 20 && koltuk > 0 && koltuk != 0)
                            {
                                
                                Console.WriteLine($"{koltuk} numaralı koltuk başkası adına rezerve edilmiştir");
                                Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                            }

                            foreach (var item in secilenKoltuk)
                            {
                                if (item == koltuk)
                                {
                                    Console.WriteLine($"Başkası adına rezerve edilmiştir.");
                                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                    dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                }
                            }

                        } while (!dogrumu);

                        Array.Resize(ref secilenKoltuk, secilenKoltuk.Length + 1);
                        secilenKoltuk[secilenKoltuk.Length - 1] = koltuk;
                        int bulunan = Array.IndexOf(ekonomi, koltuk);
                        Array.Clear(ekonomi, bulunan, 1);
                        Array.Sort(ekonomi);
                        Array.Reverse(ekonomi);
                        Array.Resize(ref ekonomi, ekonomi.Length - 1);
                        name[name.Length-1] = AdSoyad();                      
                        Console.WriteLine($"{secilenKoltuk[secilenKoltuk.Length-1]} numaralı koltuk {name[name.Length-1]} adına rezerve edilmiştir.");
                        Console.WriteLine("\n");
                        gelenCevap = YeniRezervasyon();
                        Console.Clear();

                        if (gelenCevap == "E")
                        {
                            if (ekonomi.Length == 0 && business.Length != 0)
                            {
                                Console.WriteLine("Ekonomi sınıfındaki tüm uçuşlar doludur.Business Class dan seçim yapmak istermisiniz(E/H)");
                                cevap = Console.ReadLine().ToUpper();

                                if (cevap == "E")
                                {                                  
                                    do
                                    {
                                        do
                                        {
                                            Console.WriteLine("Business Class için mevcut olan boş koltuklar aşağıdkai gibidir.\n");

                                            foreach (var item in business)                                           
                                                Console.Write($" *{item}\n");
                                            
                                            dogrumu = int.TryParse(Console.ReadLine(), out koltuk);

                                            if (koltuk <= 0)
                                            {                                               
                                                Console.WriteLine("Hatalı birr koltuk seçimi yyaptıınız");
                                                dogrumu = false;
                                            }

                                            if (koltuk != 3 && koltuk != 4 && koltuk != 6 && koltuk != 7 && koltuk > 0 && koltuk != 0)
                                            {
                                                Console.WriteLine($"{koltuk} numaralı koltuk başkası adına rezerve edilmiştir");
                                                Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                                dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                            }

                                            foreach (var item in secilenKoltuk)
                                            {
                                                if (item == koltuk)
                                                {
                                                    Console.WriteLine($"Başkası adına rezerve edilmiştir.");
                                                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                                    dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                                }

                                            }

                                        } while (!dogrumu);

                                        Array.Resize(ref secilenKoltuk, secilenKoltuk.Length + 1);
                                        secilenKoltuk[secilenKoltuk.Length - 1] = koltuk;
                                        int bulunan2 = Array.IndexOf(business, koltuk);
                                        Array.Clear(business, bulunan2, 1);
                                        Array.Sort(business);
                                        Array.Reverse(business);
                                        Array.Resize(ref business, business.Length - 1);
                                        Array.Resize(ref name, name.Length + 1);
                                        name[name.Length-1] = AdSoyad();
                                        Console.WriteLine($"{secilenKoltuk[secilenKoltuk.Length - 1]} numaralı koltuk {name[name.Length - 1]} adına rezerve edilmiştir.");
                                        Console.WriteLine("\n");
                                        gelenCevap = YeniRezervasyon();
                                        Console.Clear();

                                    } while (gelenCevap == "E" && business.Length !=0);


                                    if (gelenCevap =="H")                                                                          
                                        Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.\n");                                                                               
                                    

                                   if (ekonomi.Length == 0 && business.Length == 0)
                                        Console.WriteLine("Tüm koltuklar rezerve  edilmiştir.\n");
                                }

                                else if (cevap == "H")                               
                                       Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.\n");
                                
                            }                                                 
                        }

                    }

                }

                if (sinifSecimi == 2)
                {

                    if (business.Length != 0)
                    {
                        do
                        {
                            Console.WriteLine("Seçilen sınıf için boş koltuk numaraları aşağıdaki gibidir. Lütfen seçiniz\n");

                            foreach (var item in business)
                            {
                                Console.Write($"*{ item}\n");
                            }

                            dogrumu = int.TryParse(Console.ReadLine(), out koltuk);

                            if (koltuk <= 0)
                            {                              
                                Console.WriteLine("Hatalı birr koltuk seçimi yyaptıınız");
                                dogrumu = false;
                            }

                            if (koltuk != 3 && koltuk != 4 && koltuk != 6 && koltuk != 7 && koltuk > 0 && koltuk != 0)
                            {
                                Console.WriteLine($"{koltuk} numaralı koltuk başkası adına rezerve edilmiştir");
                                Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                            }

                            foreach (var item in secilenKoltuk)
                            {
                                if (item == koltuk)
                                {
                                    Console.WriteLine($"Başkası adına rezerve edilmiştir.");
                                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                    dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                }

                            }

                        } while (!dogrumu);

                        Array.Resize(ref secilenKoltuk, secilenKoltuk.Length + 1);
                        secilenKoltuk[secilenKoltuk.Length - 1] = koltuk;
                        int bulunan = Array.IndexOf(business, koltuk);
                        Array.Clear(business, bulunan, 1);
                        Array.Sort(business);
                        Array.Reverse(business);
                        Array.Resize(ref business, business.Length - 1);
                        name[name.Length-1] =AdSoyad();                  
                        Console.WriteLine($"{secilenKoltuk[secilenKoltuk.Length-1]} numaralı koltuk {name[name.Length - 1]} adına rezerve edilmiştir.");
                        Console.WriteLine("\n");
                        gelenCevap = YeniRezervasyon();
                        Console.Clear();                  

                        if (gelenCevap == "E")
                        {
                            if (business.Length == 0 && ekonomi.Length != 0)
                            {
                                Console.WriteLine("Business sınıfındaki tüm uçuşlar doludur.Economy Class dan seçim yapmak istermisiniz (E/H)");
                                cevap = Console.ReadLine().ToUpper();

                                if (cevap == "E")
                                {

                                    do
                                    {
                                        do
                                        {
                                            Console.WriteLine("Ekonomi sınıfı için için boş koltuk numaraları aşağıdaki gibidir. Lütfen seçiniz\n");

                                            foreach (var item in ekonomi)
                                            {
                                                Console.Write($" *{item}\n");
                                            }

                                            dogrumu = int.TryParse(Console.ReadLine(), out koltuk);

                                            if (koltuk <= 0)
                                            {                                              
                                                Console.WriteLine("Hatalı birr koltuk seçimi yaptıınız");
                                                Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                                dogrumu = false;
                                            }

                                            if (koltuk != 9 && koltuk != 12 && koltuk != 13 && koltuk != 19 && koltuk != 20 && koltuk>0 && koltuk != 0 )
                                            {
                                                Console.WriteLine($"{koltuk} numaralı koltuk başkası adına rezerve edilmiştir");
                                                Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                                dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                            }

                                            foreach (var item in secilenKoltuk)
                                            {
                                                if (item == koltuk)
                                                {
                                                    Console.WriteLine($"Başkası adına rezerve edilmiştir.");
                                                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz");
                                                    dogrumu = int.TryParse(Console.ReadLine(), out koltuk);
                                                }

                                            }

                                        } while (!dogrumu);

                                        Array.Resize(ref secilenKoltuk, secilenKoltuk.Length + 1);
                                        secilenKoltuk[secilenKoltuk.Length - 1] = koltuk;
                                        int bulunan2 = Array.IndexOf(ekonomi, koltuk);
                                        Array.Clear(ekonomi, bulunan2, 1);
                                        Array.Sort(ekonomi);
                                        Array.Reverse(ekonomi);
                                        Array.Resize(ref ekonomi, ekonomi.Length - 1);
                                        Array.Resize(ref name, name.Length + 1);
                                        name[name.Length - 1] = AdSoyad();
                                        Console.WriteLine($"{secilenKoltuk[secilenKoltuk.Length - 1]} numaralı koltuk {name[name.Length - 1]} adına rezerve edilmiştir.");
                                        Console.WriteLine("\n");
                                        gelenCevap = YeniRezervasyon();

                                        Console.Clear();

                                    } while (gelenCevap == "E" && ekonomi.Length != 0);

                                    if (gelenCevap =="H")                                   
                                        Console.WriteLine("bir sonraki uçuş kayıtları 4 saat sonradır.\n");                                   

                                    if (ekonomi.Length == 0 && business.Length == 0)
                                        Console.WriteLine("Tüm koltuklar rezerve  edilmiştir.\n");

                                }
                                else if (cevap == "H")                                
                                        Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.\n");
                                    
                            }                                                 
                        }
                    }

                }
    
          } while (ekonomi.Length != 0 && business.Length != 0 && gelenCevap == "E");

            Console.WriteLine("Yapmış olduğuuz rezervasyonlar aşağıdaki gibidir.\n************************************************");
            for (int j = 0; j < secilenKoltuk.Length; j++)
                Console.WriteLine($"{j + 1} . rezervasyonunuz; {name[j]} adına {secilenKoltuk[j]} numaralı koltuğa yapılmıştır.\n");
        }

        private static string AdSoyad() 
        {
            string Ad;
            string name=string.Empty;

            Console.Write("Lütfen yolcunun Adı ve Soyadını Türkçe karakter kullanmadan giriş yapınız:  ");
            Ad = Console.ReadLine().ToUpper().Trim();
            char[] metin = Ad.ToCharArray();

            foreach (char item in metin)
            {
                if (0 <= item && item <= 31 || 33 <= item && item <= 64 || 91 <= item && item <= 127)
                {
                    Console.WriteLine("Hatalı giriş yaptınız tekrar giriş yapınız");
                    return AdSoyad();

                }
                else
                {
                    name = Ad;
                }
            }
            return name;

        }

        private static string YeniRezervasyon() 
        {           
            string cevap;
            do
            {
                Console.WriteLine("Yeni bir rezervasyon yapmak istermisiniz E/H");
                cevap = Console.ReadLine().ToUpper();

                if (cevap != "E" && cevap != "H")
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız lüffen tekrar giriş yapıınız");
                    cevap = Console.ReadLine().ToUpper();
                }

            } while (cevap!="E"&& cevap!="H");

              return cevap;
        }
        private static void Kapanis() 
        {
            Console.WriteLine("*******BİZİ TERCİH ETTİĞİNZ İÇİN TEŞEKKÜR EDERİZ*******");
        }
       
          
        

            
    }
}
