using System;

namespace Taschenrechner_2
{
    class Program
    {
        static string HoleZahl(string ausgabetext)
        {
            Console.WriteLine(ausgabetext);
            string Zahl = Console.ReadLine();
            return Zahl;

        }


        static double WandleInDouble(string zahl)
        {
            double gewandelt = Convert.ToDouble(zahl);
            return gewandelt;
        }

        static void Main(string[] args)
        {


            //Eingabe
            string erste = HoleZahl("gibt die erste Zahl ein:");
            string zweite = HoleZahl("gibt die zweite Zahl ein:");
            //wandel in´Double
            double ersted = WandleInDouble(erste);
            double zweited = WandleInDouble(zweite);

            //addieren
            double erg = Addiere(ersted, zweited);
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
