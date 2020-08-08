/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			Dividieren.cs
Einsatz:		run.cs
Beschreibung:	Dividiert zwei Brüche.
Funktionen:		static Bruch Dividieren(Bruch eins, Bruch zwei)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn
13.06.2017:     Kleine Anpassungen, Fehlerausgabe
08.08.2020:     Überarbeitet, Meyer
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
        static Bruch Dividieren(Bruch eins, Bruch zwei)
        {
            Bruch ergebnis;
            ergebnis.zaehler = 0;
            ergebnis.nenner = 0;

            if (zwei.zaehler == 0)
            {
                Console.WriteLine("Der zweite Bruch ist Null. Teilung nicht moeglich.");
                Console.WriteLine("Abbruch!");
                Console.WriteLine("");
                Console.WriteLine("ENTER...");
                Console.ReadLine();
                
                ergebnis.zaehler = eins.zaehler;
                ergebnis.nenner = eins.nenner;
                return ergebnis;
            }

            ergebnis.zaehler = eins.zaehler * zwei.nenner;
            ergebnis.nenner = eins.nenner * zwei.zaehler;

            return ergebnis;
        }
    }
}
