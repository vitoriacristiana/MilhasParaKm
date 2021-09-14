using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {   
            double ml, convkm;
            Console.Write("Digite a medida em milhas:");
            ml= double.Parse(Console.ReadLine());
            convkm= ml * 16009;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{convkm} Km");
            Console.ResetColor();

        }
    }
}
