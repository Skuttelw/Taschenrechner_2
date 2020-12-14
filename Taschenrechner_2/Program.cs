using System;

namespace Taschenrechner_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Eingabe der Zahlen
            Console.WriteLine("gibt die Erste Zahl ein:");
            string ersteZahl = Console.ReadLine(); 
            Console.WriteLine("gibt die Zweite Zahl ein:");
            string zweiteZahl = Console.ReadLine();


            //Umwandeln in ein Double
            double erste = Convert.ToDouble(ersteZahl);
            double zweite = Convert.ToDouble(zweiteZahl);

            double erg= Addiere(erste, zweite);
            //Ausgabe
            Console.WriteLine("das Ergebnis lautet {0}", erg);


            WartenaufBenutzereingabe();
            
            






        }
        static void WartenaufBenutzereingabe()
        {
            Console.WriteLine("Zum Beenden bitte Return drücken");
            Console.ReadLine();
        }
        static double Addiere(double ersteZahl, double zweiteZahl)
        {
            //Berechnung
            double erg = ersteZahl + zweiteZahl;
            return erg;

        }
    }
}
