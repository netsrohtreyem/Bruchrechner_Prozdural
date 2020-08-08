/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Meyer
Klasse:			
Datum:			08.08.2020
Datei:			Menue.cs
Einsatz:		run.cs
Beschreibung:	Anzeige des Menues
Funktionen:		Auslesen der Auswahl
******************************************************************************
Aenderungen:
08.08.2020:     Beginn
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
        static char Menue()
        {
            char auswahl=' ';
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("------------------------- Hauptmenü -------------------------");
            Console.WriteLine("");
            Console.WriteLine("     (0) - Brüche addieren.       [ + ]");
            Console.WriteLine("     (1) - Brüche subtrahieren.   [ - ]");
            Console.WriteLine("     (2) - Brüche multiplizieren. [ * ]");
            Console.WriteLine("     (3) - Brüche dividieren.     [ / ]");
            Console.WriteLine("");
            Console.WriteLine("     (4) - Beenden.");
            Console.WriteLine("");

            //  Der Benutzer kann nun zwischen Funktionen des Programms waehlen.
            //  Die Funktionsnamen bzw. Beschreibungen sollten selbsterklaerend sein.
            while (!Console.KeyAvailable) ;
            ConsoleKeyInfo id = Console.ReadKey(true);
            auswahl = id.KeyChar;

            return auswahl;
        }
    }
}