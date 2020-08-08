/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			print.cs
Einsatz:		run.cs
 *              kuerzen.cs
Beschreibung:	Methoden fuer die Konsolenausgabe der Brueche.
Funktionen:		static void print(String rechenzeichen, String a, String b, String c, String d)
 *              static Bruch print(Bruch ergebnis)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn 	
12.06.2017:     Anpassungen Ausgabe fuer ganze Zahlen
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
        //  Methode zur Ausgabe von Zwischenschritten bei
        //  der Eingabe einer Rechnung.
        static void print(char rechenzeichen, String a, String b, String c, String d)
        {
            Console.Clear();
            Console.WriteLine("          "+a+"       "+c);
            Console.WriteLine("Format:  ---  " + rechenzeichen + "  ---");
            Console.WriteLine("          "+b+"       "+d);
            Console.WriteLine("");
        }

        //  Methode zur Ausgabe vom Ergebnis. 
        static void print(Bruch ergebnis)
        {
            Bruch Anzeige = new Bruch();
            Anzeige.zaehler = ergebnis.zaehler;
            Anzeige.nenner = ergebnis.nenner;

            bool negativ = false;
            String ganzeZahl = "";
            //Vorzeichen?
            if(ergebnis.zaehler < 0 && ergebnis.nenner > 0)
            {
                Anzeige.zaehler = Anzeige.zaehler * (-1);
                negativ = true;
            }
            else if(ergebnis.zaehler > 0 && ergebnis.nenner < 0)
            {
                Anzeige.nenner = Anzeige.nenner * (-1);
                negativ = true;
            }
            else
            {
                negativ = false;
            }

            if (ergebnis.zaehler == ergebnis.nenner)
            {
                ganzeZahl = "1";
                Anzeige.zaehler = 1;
                Anzeige.nenner = 1;
            }
            else
            { }

            if (negativ)
            {
                ganzeZahl = "-" + ganzeZahl;
            }
            else
            {
                ganzeZahl = "+" + ganzeZahl;
            }
            if (Anzeige.zaehler == 0)
            {
                Console.Clear();
                Console.WriteLine("ERGEBNIS: 0");
                Console.WriteLine("");
            }
            else if (Anzeige.zaehler == 1 && Anzeige.nenner == 1)
            {
                Console.Clear();
                Console.WriteLine("ERGEBNIS: 1");
                Console.WriteLine("");
            }
            else if(Anzeige.nenner == 1)
            {
                Console.Clear();
                Console.WriteLine("ERGEBNIS: " + Anzeige.zaehler);
                Console.WriteLine("");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("             " + Anzeige.zaehler);
                Console.WriteLine("ERGEBNIS: " + ganzeZahl + " ---");
                Console.WriteLine("             " + Anzeige.nenner);
                Console.WriteLine("");
            }
        }
    }
}
