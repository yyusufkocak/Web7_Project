using System;

namespace Soru_If_01_j
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrencinin not ortalaması vize notunun yüzde kırkı final notunun yüzde altmışı ile toplanarak hesaplanıyor 
            //geçme notu ise altmış ve üzeridir.
            //buna göre vize ve fial notu girilen öğrencinin başarı durumunun ve not ort. gösteren programı yazınız.


            double vize, final,notOrt;
            Console.WriteLine("Vize notunu girin.");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunu girin.");
            final = Convert.ToInt32(Console.ReadLine());

            vize = vize * 40 / 100;
            final = final * 70 / 100;

            notOrt = vize + final;

            Console.WriteLine($"not ortalamanız {notOrt}");


            Console.WriteLine("başarı durumunu sorgulamak için enter basın");

            Console.ReadLine();
            


            if (notOrt>=70)
            {
                Console.WriteLine("Harikasın");
            }
      
            else if (notOrt>=40)
            {
                Console.WriteLine("Bütlere kaldın");
            }
            else
            {
                Console.WriteLine("Kaldın");
            }
            Console.ReadLine();
        }
    }
}
