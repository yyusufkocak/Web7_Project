using System;

namespace Proje_08_for_j
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //int toplam = 0;
            //for (int i = 2; i <= 10; i+=2)
            //{


            //        toplam += i;

            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();


            // bir ile yüz arasındaki asal sayıları ekrana yazdıran program



            //int asalE;
            //bool asal=false;

            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j != 0)
            //        {
            //            asal = true;
            //            asalE = i;
            //            Console.WriteLine(asalE);

            //        }


            //    }


            //}
            //Console.ReadLine();
            //bool asal = true;

            //for (int i = 2; i <= 100; i++)
            //{

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            asal = false;
            //            break;

            //        }
            //    }
            //    if (asal)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    asal = true;

            //}
            //Console.ReadLine();

            // bool asal = true;
            //int sayac = 1, sayac2 = 1, sayac3 = 1;

            // for (int i = 2; i <= 300; i++)
            // {

            //     for (int j = 2; j < i; j++)
            //     {
            //         if (i % j == 0)
            //         {
            //             asal = false;
            //             break;

            //         }
            //     }
            //     if (asal)
            //     {

            //         if (i < 100)
            //         {
            //             sayac++;


            //         }

            //        else if (i<=200)
            //         {
            //             sayac2++;

            //         }
            //         else 
            //         {
            //             sayac3++;

            //         }

            //     }
            //     asal = true;

            // }
            // Console.WriteLine($"1-100 arasında {sayac} asal sayı var\n 101-200rasında {sayac2} asal sayı var\n201-300 arasında {sayac3} asal sayı var");


            //Console.ReadLine();



            //for (int i = 0; i < 5; i++)
            //{

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($" {i * j}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();



        }
    }
}
