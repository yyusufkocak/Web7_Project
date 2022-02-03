using System;

namespace Proje_3_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int numara;
            numara = 10;
            //Console.WriteLine(numara); // cw snippet

            //camelCase  
            string adSoyad = "Josef";
            //Console.WriteLine(adSoyad);


            Console.Write(numara);
            Console.Write("-");
            Console.WriteLine(adSoyad);
            Console.WriteLine(numara+ "-"+ adSoyad);
            Console.WriteLine($"Merhaba {numara} numaralı - {adSoyad} ");
            Console.ReadLine();
        }
    }
}
