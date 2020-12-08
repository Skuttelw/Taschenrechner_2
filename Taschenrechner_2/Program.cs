using System;

namespace Taschenrechner_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gibt die Erste Zahl ein:");
            string ersteZahl = Console.ReadLine(); 
            Console.WriteLine("gibt die Zweite Zahl ein:");
            string zweiteZahl = Console.ReadLine();

            double erste = Convert.ToDouble(ersteZahl);
            double zweite = Convert.ToDouble(zweiteZahl);


            double erg = erste + zweite;
            Console.WriteLine("das Ergebnis lautet {0}", erg);

            Console.ReadLine();

        }
    }
}
