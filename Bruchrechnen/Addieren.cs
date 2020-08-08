/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			Addieren.cs
Einsatz:		run.cs
Beschreibung:	Addiert zwei Brüche.
Funktionen:		static Bruch Addieren(Bruch eins, Bruch zwei)
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
        static Bruch Addieren(Bruch eins, Bruch zwei)
        {
            Bruch ergebnis = new Bruch();

            ergebnis.zaehler = eins.zaehler * zwei.nenner + zwei.zaehler * eins.nenner;
            ergebnis.nenner = eins.nenner * zwei.nenner;

            return ergebnis;
        }
    }
}
