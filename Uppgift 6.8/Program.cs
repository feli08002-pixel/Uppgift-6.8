using System;

namespace Uppgift6_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv ett heltal:");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Antal primtal mindre än " + tal + ": " + AntalPrimtalMindreÄn(tal));
        }

        static int AntalPrimtalMindreÄn(int gräns)
        {
            int antal = 0;
            for (int i = 2; i < gräns; i++)
                if (ÄrPrimtal(i))
                    antal++;
            return antal;
        }

        static bool ÄrPrimtal(int tal)
        {
            if (tal < 2) return false;
            for (int i = 2; i < tal; i++)
                if (tal % i == 0)
                    return false;
            return true;
        }
    }
}

