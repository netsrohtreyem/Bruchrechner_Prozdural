/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			run.cs
Einsatz:		Main.cs
Beschreibung:	Steuerung Hauptprogramm.
Funktionen:		static void run(Bruch pEins, Bruch pZwei, Bruch pErgb)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn
08.08.2020:     Angepasst, Meyer
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechnen
{
    partial class main
    {
        static void run(ref Bruch pEins, ref Bruch pZwei, ref Bruch ergebnis)
        {
            bool weiter = true;

            //Splashscreen anzeigen
            splash();

            //Hauptschleife
            while (weiter)
            {
                //Menü anzeigen und einlesen
                char auswahl = Menue();

                //Auswerten und Ausführen
                if (auswahl == '0')
                {
                    Console.Clear();
                    print('+', "A", "B", "C", "D");
                    Console.WriteLine("Bitte den Zähler des ersten Bruchs angeben (A):");
                    pEins.zaehler = parser(Console.ReadLine(), 1);

                    print('+', "" + pEins.zaehler, "B", "C", "D");
                    Console.WriteLine("Bitte den Nenner des ersten Bruchs angeben (B):");
                    pEins.nenner = parser(Console.ReadLine(), 2);

                    print('+', "" + pEins.zaehler, "" + pEins.nenner, "C", "D");
                    Console.WriteLine("Bitte den Zähler des zweiten Bruchs angeben (C):");
                    pZwei.zaehler = parser(Console.ReadLine(), 1);

                    print('+', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "D");
                    Console.WriteLine("Bitte den Nenner des zweiten Bruchs angeben (D):");
                    pZwei.nenner = parser(Console.ReadLine(), 2);

                    print('+', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "" + pZwei.nenner);
                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();

                    ergebnis = Addieren(pEins, pZwei);
                    ergebnis = Kuerzen(ergebnis);
                    print(ergebnis);

                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();
                    weiter = true;
                }
                else if (auswahl == '1')
                {
                    Console.Clear();
                    print('-', "A", "B", "C", "D");
                    Console.WriteLine("Bitte den Zähler des ersten Bruchs angeben (A):");
                    pEins.zaehler = parser(Console.ReadLine(), 1);

                    print('-', "" + pEins.zaehler, "B", "C", "D");
                    Console.WriteLine("Bitte den Nenner des ersten Bruchs angeben (B):");
                    pEins.nenner = parser(Console.ReadLine(), 2);

                    print('-', "" + pEins.zaehler, "" + pEins.nenner, "C", "D");
                    Console.WriteLine("Bitte den Zähler des zweiten Bruchs angeben (C):");
                    pZwei.zaehler = parser(Console.ReadLine(), 1);

                    print('-', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "D");
                    Console.WriteLine("Bitte den Nenner des zweiten Bruchs angeben (D):");
                    pZwei.nenner = parser(Console.ReadLine(), 2);

                    print('-', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "" + pZwei.nenner);
                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();

                    ergebnis = Subtrahieren(pEins, pZwei);
                    ergebnis = Kuerzen(ergebnis);
                    print(ergebnis);

                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();
                    weiter = true;
                }
                else if (auswahl == '2')
                {
                    Console.Clear();
                    print('*', "A", "B", "C", "D");
                    Console.WriteLine("Bitte den Zähler des ersten Bruchs angeben (A):");
                    pEins.zaehler = parser(Console.ReadLine(), 1);

                    print('*', "" + pEins.zaehler, "B", "C", "D");
                    Console.WriteLine("Bitte den Nenner des ersten Bruchs angeben (B):");
                    pEins.nenner = parser(Console.ReadLine(), 2);

                    print('*', "" + pEins.zaehler, "" + pEins.nenner, "C", "D");
                    Console.WriteLine("Bitte den Zähler des zweiten Bruchs angeben (C):");
                    pZwei.zaehler = parser(Console.ReadLine(), 1);

                    print('*', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "D");
                    Console.WriteLine("Bitte den Nenner des zweiten Bruchs angeben (D):");
                    pZwei.nenner = parser(Console.ReadLine(), 2);

                    print('*', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "" + pZwei.nenner);
                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();

                    ergebnis = Multiplizieren(pEins, pZwei);
                    ergebnis = Kuerzen(ergebnis);
                    print(ergebnis);

                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();
                    weiter = true;
                }
                else if (auswahl == '3')
                {
                    Console.Clear();
                    print('/', "A", "B", "C", "D");
                    Console.WriteLine("Bitte den Zähler des ersten Bruchs angeben (A):");
                    pEins.zaehler = parser(Console.ReadLine(), 1);

                    print('/', "" + pEins.zaehler, "B", "C", "D");
                    Console.WriteLine("Bitte den Nenner des ersten Bruchs angeben (B):");
                    pEins.nenner = parser(Console.ReadLine(), 2);

                    print('/', "" + pEins.zaehler, "" + pEins.nenner, "C", "D");
                    Console.WriteLine("Bitte den Zähler des zweiten Bruchs angeben (C):");
                    pZwei.zaehler = parser(Console.ReadLine(), 1);

                    print('/', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "D");
                    Console.WriteLine("Bitte den Nenner des zweiten Bruchs angeben (D):");
                    pZwei.nenner = parser(Console.ReadLine(), 2);

                    print('/', "" + pEins.zaehler, "" + pEins.nenner, "" + pZwei.zaehler, "" + pZwei.nenner);
                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();

                    ergebnis = Dividieren(pEins, pZwei);
                    ergebnis = Kuerzen(ergebnis);
                    print(ergebnis);

                    Console.WriteLine("Drücken Sie ENTER...");
                    Console.ReadLine();
                    weiter = true;
                }
                else if(auswahl == '4')
                {
                    Console.Clear();
                    Console.WriteLine("Programm wird beendet!");
                    Console.WriteLine("Taste druecken");
                    while (!Console.KeyAvailable) ;
                    Console.ReadKey(false);
                    
                    weiter = false;
                }
                else
                {
                    //  Das Waehlen eines unaufgefuehrten Menuepunkts fuehrt zu einer Meldung.
                    //  Man landet erneut im Hauptmenue (rekursiv).
                    Console.WriteLine("");
                    Console.WriteLine("Menuepunkt " + auswahl + " gibt es nicht. Bitte erneut..");
                    Console.ReadLine();
                    weiter = true;
                }
            }
        }
    }
}
