using System;

namespace Proje_05_Convert_Typesj
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad;
            //Console.Write("Adınızı Giriniz: ");
            //ad = Console.ReadLine();
            //Console.WriteLine($"Merhaba {ad}");
            //int yas;
            //Console.Write("Yaşınızı Giriniz: ");
            //yas =int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sen {yas} yaşındasın.");


            //int sNot = Convert.ToInt32(Console.ReadLine());
            //double gNot = sNot * 17 / 100;
            //Console.WriteLine(gNot);
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine(sNot*17/100);

            //byte sayi = 96;
            //int sayi2 = sayi; //Örtülü (bilinçsiz) Tür Dönüşümü
            int sayi = 256;
            byte sayi2 = (byte)sayi;
            Console.WriteLine(sayi2);
            Console.ReadLine();
        }
    }
}
