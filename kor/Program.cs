using System;

namespace kor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sugar;

            Console.Write("Kérem a kör sugarát: ");

            sugar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Terulet: {Math.Pow(sugar, 2) * Math.PI}");
            Console.WriteLine($"Kerulet: {2 * sugar * Math.PI}");
            
            Console.ReadKey();
        }
    }
}
