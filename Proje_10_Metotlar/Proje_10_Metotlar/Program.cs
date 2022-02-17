using System;

namespace Proje_10_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            void Toplama()
            {
                int s1 = 10;
                int s2 = 20;

                Console.WriteLine(s1+s2);
            }
            void GirisYap()
            {
                Console.Clear();
                Console.Write("Lütfen Kullanıcı Adınızı Girin: ");
                string ad = Console.ReadLine();
            }

            //Toplama();
            //Console.WriteLine("Hello World");
            //Console.ReadLine();
            //GirisYap();
            //Console.WriteLine("Hello World");
            //Toplama();
            //Toplama();
            //Console.ReadLine();
            //GirisYap();
            //Console.ReadLine();

            void Merhaba(string ad,int yil)
            {
                Console.WriteLine($"Merhaba {ad}, hoşgeldin. Bu {yil}.yılın");
            }



            Merhaba("Engin",25);
            Console.ReadLine();

            int a = 5;

            int KareBul()
            {
                return a * a;
            }

            int KareBul2(int kenarUzunluğu)
            {
                return kenarUzunluğu * kenarUzunluğu;
            }


            int karesi = KareBul();
            int karesiniBul = KareBul2(7);

            Console.WriteLine(karesi);
            Console.WriteLine(karesiniBul);

            Console.ReadLine();
            
          
           
        }
    }
}
