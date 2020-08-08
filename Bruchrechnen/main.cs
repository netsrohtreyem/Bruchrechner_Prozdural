/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			main.cs
Einsatz:		Programm
Beschreibung:	Initialisierung u. Deklaration der noetigen Variablen, 
 *              Aufruf Hauptprogramm
Funktionen:		static void Main(string[] args)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn 	 
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
        // zaehler / nenner
        public struct Bruch
        {
            public int zaehler;
            public int nenner;
        }

        static void Main(string[] args)
        {
            //Zentrale Daten
            Bruch eins = new Bruch();
            Bruch zwei = new Bruch();
            Bruch ergebnis = new Bruch();

            //Hauptprogramm
            run(ref eins, ref zwei, ref ergebnis);

            //evtl. Daten sichern
        }
    }
}
