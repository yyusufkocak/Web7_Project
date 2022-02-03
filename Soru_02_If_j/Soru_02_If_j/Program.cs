using System;

namespace Soru_02_If_j
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir mağazada alınan iki ürünün tutarları toplamı 200 liranın üzerindeyse;
            //ikinci ürüne yüzde otuzbeş indirim uygulanmanktadır
            //ayrıca tutar toplamı 250 tlnin üstündeyse(tutar top.indirim uygulanmış hali )
            //her alışverişte alınan 25 tl kargo bedeli alınmamaktadır
            //bu duruma göre iki ürünün fiyatlarının girilmesini sağlayan ve ödenecek topl. turarı hesaplayıp ekrana 
            //ayrı ayrı her ürünün fiyatlarıyla birlikte 
            //genel toplam
            //indirim uygulanmışsa indirimli tutar 
            //kargo bedeli 
            //ödenecek top. tutar.yazdıracak programı hazırlayınız

            double bUrun, iUrun, gToplam;

            Console.WriteLine("1. Ürünün fiyatı");
            bUrun = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Ürünün fiyatı");
            iUrun = Convert.ToDouble(Console.ReadLine());

            gToplam = bUrun + iUrun;
            if (gToplam>200 && gToplam<250)
            {
                Console.WriteLine($"Genel Toplam {gToplam}");
                Console.WriteLine($"1.Ürün Fiyatı : {bUrun}");
                Console.WriteLine($"2.Ürün Fiyatı : {iUrun}");
                iUrun = iUrun - (iUrun * 35 / 100);
                gToplam = bUrun + iUrun +25;
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"1.Ürün Fiyatı : {bUrun}");
                Console.WriteLine($"İndirimli 2.Ürün Fiyatı : {iUrun}");
                Console.WriteLine($"İndirimli Kargo Dahil Genel Toplam : {gToplam}");
                Console.WriteLine($"Kargo Bedeli : 25 Tl");
                Console.ReadLine();
            }
            else if(gToplam > 250)
            {
                Console.WriteLine($"Genel Toplam {gToplam}");
                Console.WriteLine($"1.Ürün Fiyatı : {bUrun}");
                Console.WriteLine($"2.Ürün Fiyatı : {iUrun}");
                iUrun = iUrun - (iUrun * 35 / 100);
                gToplam = bUrun + iUrun ;
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"1.Ürün Fiyatı : {bUrun}");
                Console.WriteLine($"İndirimli 2.Ürün Fiyatı : {iUrun}");
                Console.WriteLine($"İndirimli Genel Toplam : {gToplam}");
                Console.WriteLine($"Kargo Bedeli : 0 Tl");
                
                Console.ReadLine();
            }
            else if (gToplam<200) 
            {
                gToplam = bUrun + iUrun ;
               
                Console.WriteLine($"1.Ürün Fiyatı : {bUrun}");
                Console.WriteLine($"2.Ürün Fiyatı : {iUrun}");
                Console.WriteLine($"Genel Toplam {gToplam}");
                Console.WriteLine($"Kargo Bedeli : 25 Tl");
                Console.WriteLine($"İndirimli Kargo Dahil Genel Toplam : {gToplam + 25}");


                Console.ReadLine();
            }


        }
    }
}
