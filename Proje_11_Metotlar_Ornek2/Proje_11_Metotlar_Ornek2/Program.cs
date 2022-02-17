using System;

namespace Proje_11_Metotlar_Ornek2
{
    class Program
    {
        //static bir olay için yine static kullanırız.
       static int Topla(int number1,int number2)
        {
            return number1 + number2;
        }
        static int Topla(int number1, int number2,int number3)
        {
            return number1 + number2 + number3;
        }
        static int Fakt(int sayi=5)
        {
            int sonuc=1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }
        static int EnBuyuk(int[] numbers)
        {
            int enBuyuk = 1;

            for (int i = 0; i <numbers.Length ; i++)
            {

                if (numbers[i] > enBuyuk)
                {
                    enBuyuk = numbers[i];
                }

            }
            return enBuyuk;

        }
        static int BuyukKucuk(int[] numbers,bool islem)
        {

            
                int sonuc = numbers[0];

            foreach (var sayi in numbers)
            {
                if (islem)
                {
                    if (sayi>=sonuc)
                    {
                        sonuc = sayi;
                    }
                }
                else
                {
                    if (sayi <= sonuc)
                    {
                        sonuc = sayi;
                    }
                }
            }
            return sonuc;
      
        }
        static void Main(string[] args)
        {

            //klavyeden girilecek sayının fakt. yazdıracak metotlu program

            //Console.WriteLine("Sayi Girin");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayi = Fakt();
            //Console.ReadLine();
            //Console.WriteLine(sayi);
            //Console.ReadLine();


            int[] sayilar = {50,450,87,96,65};



            int kucuk = BuyukKucuk(sayilar,false);
            Console.WriteLine(kucuk);

            Console.ReadLine();


            //Console.WriteLine(Topla(5,6));
            //Console.ReadLine();
            //Console.WriteLine();
            
        }
    }
}
