using System;

namespace L2_7_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten program sprawdzi czy wpisany rok jest przestępny.");
            Console.Write("Podaj rok: ");

            Int32.TryParse(Console.ReadLine(), out int yearToCheck);

            if ((yearToCheck % 4 == 0) && (yearToCheck % 100 != 0) || (yearToCheck % 400 == 0))
            {
                Console.WriteLine($"Wpisany rok {yearToCheck} jest przestępny.");
            } 
            else
            {
                Console.WriteLine($"Wpisany rok {yearToCheck} nie jest przestępny.");
            }
        }
    }
}
