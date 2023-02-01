using System;
namespace Uppgift_2._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            string strNr1 = Console.ReadLine();
            double fltNr1 = Convert.ToDouble(strNr1);
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string strNr2 = Console.ReadLine();
            double fltNr2 = Convert.ToDouble(strNr2);
            double skillnad = fltNr1 - fltNr2;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma.");
        }
    }
}

