/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			subtrahieren.cs
Einsatz:		run.cs
Beschreibung:	Subtrahiert zwei Brüche.
Funktionen:		static Bruch Subtrahieren(Bruch eins, Bruch zwei)
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
        static Bruch Subtrahieren(Bruch eins, Bruch zwei)
        {
            Bruch ergebnis;
            ergebnis.zaehler = 0;
            ergebnis.nenner = 0;

            if (eins.nenner == zwei.nenner)
            {
                ergebnis.zaehler = eins.zaehler - zwei.zaehler;
                ergebnis.nenner = eins.nenner;
            }
            else
            {
                int z1 = eins.zaehler;
                int n1 = eins.nenner;
                int z2 = zwei.zaehler;
                int n2 = zwei.nenner;

                eins.nenner = n2 * n1;
                eins.zaehler = n2 * z1;

                zwei.nenner = n1 * n2;
                zwei.zaehler = n1 * z2;

                ergebnis.zaehler = eins.zaehler - zwei.zaehler;
                ergebnis.nenner = eins.nenner;
            }

            return ergebnis;
        }
    }
}
