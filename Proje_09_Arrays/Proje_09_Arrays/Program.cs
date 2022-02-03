using System;

namespace Proje_09_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilecek 3 tane sayıdan en büyük sayının hangisi

            //Console.WriteLine("3 tane sayı girin ");
            //int a, b, c;

            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());



            //if (a>b && a>c)
            //{
            //    Console.WriteLine($"En büyük sayı {a}");
            //}
            //else if(b > a && b > c)
            //{
            //    Console.WriteLine($"En büyük sayı {b}");

            //}
            //else
            //{
            //    Console.WriteLine($"En büyük sayı {c}");

            //}

            //Console.ReadLine();

            //Console.WriteLine("3 tane sayı girin ");

            //int enBuyuk = 0;
            //int sayi = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i}. Sayıyı Girin : ");
            //    sayi = int.Parse(Console.ReadLine());

            //    if (sayi>enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }

            //}

            //Console.WriteLine($"En büyük sayı: {enBuyuk}");
            //Console.ReadLine();[]

            //int[] sayilar = {4,6,9};
            //Console.WriteLine(sayilar[1]);

            //Random rnd = new Random();

            ////int rastgeleSayi = rnd.Next(1,10);
            ////Console.WriteLine(rastgeleSayi);


            //// bir diziye rastgele 10 sayı ekleme

            //int[] dizi = new int[10];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(1,100);
            //}

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Console.ReadLine();

            //rastgele 5 değer oluşturalım 1-100 arası
            //sonra sıraları ters çevirin
            //ekranda iki halini görelim


            //Random rnd = new Random();
            //int[] array =new int[5];
            //int[] tempArray = new int[5];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(1, 100);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{

            //    tempArray[i] = array[4- i];
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);

            //    Console.WriteLine(tempArray[i]);
            //}
            //Console.ReadLine();

            //Random rnd = new Random();
            //string[] kisiler = {
            //    "Elif",
            //    "Ayşen",
            //    "Umay",
            //    "Begüm",
            //    "Ceyda"
            //};

            //foreach (var kisi in kisiler)
            //{
            //    Console.WriteLine(kisi);
            //}


            //Console.ReadLine();


            //toplam 5 dakika

            //bool restart = false;


            //do
            //{

            //    Console.Clear();

            //    Random rnd = new Random();
            //    int tSayi = rnd.Next(1, 100);

            //    Console.WriteLine(tSayi);

            //    int gSayi;
            //    int puan = 100;
            //    bool esit = true;




            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (esit)
            //        {
            //            Console.WriteLine($"Sayı Girin şuanki Puanınız {puan}");
            //            Console.WriteLine();
            //            gSayi = Convert.ToInt32(Console.ReadLine());
            //            if (gSayi == tSayi)
            //            {
            //                Console.WriteLine("Tebrikler Başardınız");

            //                esit = false;
            //            }
            //            else if (gSayi < tSayi)
            //            {

            //                if (i == 4)
            //                {
            //                    Console.WriteLine("Hakkınız Bitti");
            //                    Console.WriteLine($"puanınız: {puan}");
            //                }
            //                else
            //                {
            //                    puan = puan - 10;
            //                    Console.WriteLine($"Sayıyı biraz daha küçük gir ");
            //                    Console.WriteLine();
            //                }

            //            }
            //            else if (gSayi > tSayi)
            //            {

            //                if (i == 4)
            //                {
            //                    Console.WriteLine("Hakkınız Bitti");

            //                }
            //                else
            //                {
            //                    puan = puan - 10;
            //                    Console.WriteLine($"Sayıyı biraz daha küçük gir ");
            //                    Console.WriteLine();
            //                }
            //            }
            //        }



            //    }

            //    Console.WriteLine();
            //    Console.WriteLine($"puanınız: {puan}");
            //    Console.WriteLine();
            //    Console.WriteLine("Bir Daha Oynamak İster misinz? evet için e tuşuna basın");

            //    if ("e" == Console.ReadLine())
            //    {
            //        restart = true;
            //    }

            //} while (restart == true);


            //Console.ReadLine();


            Console.WriteLine("Değer Girin : ");
            int gDeg = Convert.ToInt32(Console.ReadLine());
            int sonuc=1;

            for (int i = 1; i <= gDeg; i++)
            {
                sonuc = sonuc * i;
            }

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
