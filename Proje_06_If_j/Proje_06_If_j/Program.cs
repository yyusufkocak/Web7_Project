using System;

namespace Proje_06_If_j
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Engin";
            string gAd = Console.ReadLine();

            if (ad == gAd)
            {
                Console.WriteLine($"Hoş geldin {ad}");
            }
            else if ("Ahmet"==gAd)
            {
                Console.WriteLine($"{gAd}, sen önce parola için IT'ye başvur. İrlanda güzel miydi??");
            }
            else
            {
                Console.WriteLine($"{gAd},sen geçersiz bir kullanıcısın.Kb.Bb");
            }
            Console.ReadLine();
        }
    }
}
