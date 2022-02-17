using System;

namespace _4_02_2022_Sayi_Tahmin_Metot
{
    class Program


    {
        static int SayiUret()
        {
            Random rnd = new Random();

            return rnd.Next(1, 100);
        }

        static int SayiGir()
        {
            Console.Write("Sayı Girin : ");
            int sayi = int.Parse(Console.ReadLine());
            return sayi;
        }
        static bool SayiKontrol(int sayi, int rndSayi)
        {


            if (sayi == rndSayi)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
          
            do
            {
                Console.Clear();
                int tSayi = SayiUret();
                //Console.WriteLine(tSayi);

                int puan = 100;

                for (int i = 0; i < 5; i++)
                {
                    int gSayi = SayiGir();

                    if (SayiKontrol(gSayi, tSayi))
                    {
                        Console.WriteLine("tebrikler başardınız");
                        Console.WriteLine($"puanınız: {puan}");
                        Console.WriteLine("Bir daha oynamak için e tuşuna basın");
                        break;

                    }
                    else if (SayiKontrol(gSayi, tSayi) == false)
                    {
                        if (gSayi <= tSayi)
                        {

                            if (i == 4)
                            {
                                Console.WriteLine("Bilemediniz Hakkınız Bitti");
                                Console.WriteLine($"puanınız: {puan}");
                                Console.WriteLine("Bir daha oynamak için e tuşuna basın");
                            }
                            else
                            {
                                puan = puan - 10;
                                Console.WriteLine($"Sayıyı biraz daha büyük gir ");
                                Console.WriteLine($"Şuanki Puanınız {puan}");

                            }

                        }
                        else if (gSayi >= tSayi)
                        {

                            if (i == 4)
                            {
                                Console.WriteLine("Bilemediniz Hakkınız Bitti");
                                Console.WriteLine($"puanınız: {puan}");
                                Console.WriteLine("Bir daha oynamak için e tuşuna basın");
                            }
                            else
                            {
                                puan = puan - 10;
                                Console.WriteLine($"Sayıyı biraz daha küçük gir ");
                                Console.WriteLine($"Şuanki Puanınız {puan}");
                            }
                        }
                    }
                    

                }
            } while ("e" == Console.ReadLine());



           
            Console.ReadLine();

        }
    }
}
