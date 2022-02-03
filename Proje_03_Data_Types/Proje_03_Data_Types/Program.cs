using System;

namespace Proje_03_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Veri Tipleri------");
            Console.WriteLine("A) Tam Sayılar(Integer) ");
            Console.WriteLine("I)Işaretsiz(Unsigned)Tamsayılar");
            Console.WriteLine();


            Console.WriteLine("1)byte:");
            Console.WriteLine($"Minimum Değer:  {byte.MinValue}");
            Console.WriteLine($"Maximum Değer:  {byte.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki boyutu:  {sizeof(byte)} byte");
            Console.WriteLine();

            Console.WriteLine("1)ushort:");
            Console.WriteLine($"Minimum Değer:  {ushort.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer:  {ushort.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki boyutu:  {sizeof(ushort)} byte");
            Console.WriteLine();

            Console.WriteLine("1)uint:");
            Console.WriteLine($"Minimum Değer:  {uint.MinValue}");
            Console.WriteLine($"Maximum Değer:  {uint.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki boyutu:  {sizeof(uint)} byte");
            Console.WriteLine();

            Console.WriteLine("1)ulong:");
            Console.WriteLine($"Minimum Değer:  {ulong.MinValue}");
            Console.WriteLine($"Maximum Değer:  {ulong.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki boyutu:  {sizeof(ulong)} byte");

            Console.WriteLine();

            Console.WriteLine("I) Signed ");
            Console.WriteLine("1) sbyte");
            Console.WriteLine($"Minimum Değer: {sbyte.MinValue}");
            Console.WriteLine($"Minimum Değer: {sbyte.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(sbyte)} byte");

            Console.WriteLine();

            Console.WriteLine("I) Signed ");
            Console.WriteLine("2) short");
            Console.WriteLine($"Minimum Değer: {short.MinValue}");
            Console.WriteLine($"Minimum Değer: {short.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(short)} byte");


            Console.WriteLine();

            Console.WriteLine("I) Signed ");
            Console.WriteLine("3) int");
            Console.WriteLine($"Minimum Değer: {int.MinValue}");
            Console.WriteLine($"Minimum Değer: {int.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(int)} byte");

            Console.WriteLine();

            Console.WriteLine("I) Signed ");
            Console.WriteLine("4) long");
            Console.WriteLine($"Minimum Değer: {long.MinValue}");
            Console.WriteLine($"Minimum Değer: {long.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(long)} byte");

            Console.WriteLine();

            Console.WriteLine("B) Ondalıklı Sayılar(Decimal) ");


            Console.WriteLine();

            Console.WriteLine("1) float");
            Console.WriteLine($"Minimum Değer: {float.MinValue}");
            Console.WriteLine($"Minimum Değer: {float.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(float)} byte");
            Console.WriteLine();

            Console.WriteLine("2) decimal");
            Console.WriteLine($"Minimum Değer: {decimal.MinValue}");
            Console.WriteLine($"Minimum Değer: {decimal.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(decimal)} byte");
            Console.WriteLine();

            Console.WriteLine("2) double");
            Console.WriteLine($"Minimum Değer: {double.MinValue}");
            Console.WriteLine($"Minimum Değer: {double.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(double)} byte");
            Console.WriteLine();

            Console.WriteLine("C) bool");
            Console.WriteLine($"Minimum Değer: {true}");
            Console.WriteLine($"Minimum Değer: {false}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(bool)} byte");
            Console.WriteLine();


            Console.WriteLine("D) char");
            Console.WriteLine($"Maximum Değer: {(int)char.MaxValue}");
            Console.WriteLine($"Minimum Değer: {(int)char.MinValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(char)} byte");
            char kod;
            kod = 'r';
            Console.WriteLine();

            Console.WriteLine("E) DateTime");
            Console.WriteLine($"Maximum Değer: {DateTime.MaxValue}");
            Console.WriteLine($"Minimum Değer: {DateTime.MinValue}");
            unsafe
            {
                Console.WriteLine($"Bellekteki Boyutu: {sizeof(DateTime)} byte");

            }





            Console.ReadLine();
        }
    }
}
