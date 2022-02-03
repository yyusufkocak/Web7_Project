using System;

namespace Prohe_04_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------DATA TYPES---------------------------");
            Console.WriteLine("A-Int(Integer)");
            Console.WriteLine("I-Unsigned Types");

            Console.WriteLine();

            Console.WriteLine("1)byte:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Minimum Değer => {byte.MinValue}");
            Console.WriteLine($"Maximum Değer =< {byte.MaxValue}");
            Console.WriteLine($"Boyut = {sizeof(byte)} byte");
            Console.WriteLine($"2'nin 8'inci kuvveti => {Math.Pow(2,8)-1}");
            Console.WriteLine();

            Console.WriteLine("2)ushort:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Minimum Değer => {ushort.MinValue}");
            Console.WriteLine($"Maximum Değer =< {ushort.MaxValue:0,00}");
            Console.WriteLine($"Boyut = {sizeof(ushort)} byte");
            Console.WriteLine($"2'nin 8'inci kuvveti => {Math.Pow(2, 16) - 1:0,00}");
            Console.ReadLine();
        }
    }
}
