/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			Kuerzen.cs
Einsatz:		run.cs
Beschreibung:	Kuerzt Brueche, die noch zu kuerzen sind
Funktionen:		static Bruch Kuerzen_und_ausgeben(Bruch pErgebnis)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn 	
12.06.2017:     Uberarbeitung Logik, negative Zahlen werden nun ausgegeben
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
        static Bruch Kuerzen(Bruch pErgebnis)
        {
            Bruch ergebnis = pErgebnis;
            bool kuerz = true;
            bool negative = false;
            int min = 0;

            //  Gibt es negative Werte?
            //  Beide negativ -> Bruch umkehren
            //  Eine Zahl negativ -> Vorzeichen merken
            if (ergebnis.zaehler < 0 && ergebnis.nenner < 0)
            {
                ergebnis.zaehler = ergebnis.zaehler * (-1);
                ergebnis.nenner = ergebnis.nenner * (-1);
            }
            else if (ergebnis.nenner < 0)
            {
                ergebnis.nenner = ergebnis.nenner * (-1);
                negative = true;
            }
            else if (ergebnis.zaehler < 0)
            {
                ergebnis.zaehler = ergebnis.zaehler * (-1);
                negative = true;
            }
            else
            { }
            //  Minimum Teiler fuer Schleife bestimmen
            if (ergebnis.zaehler > ergebnis.nenner)
            {
                min = ergebnis.nenner;
            }
            else
            {
                min = ergebnis.zaehler;
            }

            //  Werte die fuer die Schleife ausgeschlossen sind (kuerzen ueberspringen)
            if (min == 1 || min == 0)
            {
                if (negative)
                {
                    ergebnis.zaehler = ergebnis.zaehler * (-1);
                }
                else
                { }
                return ergebnis;
            }
            else
            { }

            //  Schleife -> ermittelt Teiler zum Kuerzen und kuerzt, wenn moeglich
            //  min ist die Kleinste Zahl im Bruch, also der theoretisch kleinstmoegliche Teiler
            //  Abbruch wenn i = min oder wenn bereits ein mal gekuerzt wurde
            for (int i = 2; i < min+1; i++)
            {
                if ((ergebnis.nenner % i == 0) && (ergebnis.zaehler % i == 0))
                {
                    ergebnis.zaehler = ergebnis.zaehler / i;
                    ergebnis.nenner = ergebnis.nenner / i;
                    if (i == min)
                    {
                        kuerz = false;
                    }
                    else
                    { }
                    break;
                }
                else
                { }

                if (i == min)
                {
                    kuerz = false;
                }
                else
                { }
            }

            //  entweder nochmal rekursiv kuerzen oder beenden (asugeben)
            //  rekursiv, wenn i noch nicht gleich min war.
            //  bedeutet: der groeßtmoegliche Teiler noch nicht fuer das
            //  Kuerzen ausprobiert worden ist
            if (kuerz == true)
            {
                ergebnis = Kuerzen(ergebnis);
            }
            else
            { }

            if(negative)
            {
                ergebnis.zaehler = ergebnis.zaehler * (-1);
            }
            else
            { }
            return ergebnis;
        }
    }
}
