using System;

namespace Proje_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //{VeriTipi}[İsim];
            //{VeriTipi}[İsim] = {İlkDeger}
            
            string adSoyad;
            adSoyad = "Engin Niyazi Ergül";
            Console.WriteLine(adSoyad);

            int yas = 47;
            Console.WriteLine(yas);
            int hour = DateTime.Now.Hour;
            int year = DateTime.Today.Year;
            Console.WriteLine(year +" " + hour);

            // Merhaba [adSoyad], günün güzel geçsin
            Console.WriteLine("merhaba " + adSoyad + ", günün güzel geçsin");
            Console.WriteLine($"Merhaba {adSoyad}, günün güzel geçsin. ");
            Console.ReadLine();
            
        }
    }
}
