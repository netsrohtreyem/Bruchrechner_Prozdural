/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			splash.cs
Einsatz:		main.cs
Beschreibung:	Zeigt Splash-Screen.
Funktionen:		static void splash()
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
        static void splash()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                                                            |");
            Console.WriteLine("|    Programm: Bruchrechnen V1.00                            |");
            Console.WriteLine("|       Autor: Degtyarev                                     |");
            Console.WriteLine("|       Datum: 05/2017                                       |");
            Console.WriteLine("|              angepasst 08.08.2020, Meyer                   |");
            Console.WriteLine("|Beschreibung: Anwendung zum Rechnen mit Bruechen.           |");
            Console.WriteLine("|                                                            |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("------------------------- WILLKOMMEN -------------------------");
            Console.WriteLine("");
            Console.WriteLine("     Drücken Sie ENTER..");

            Console.ReadLine();
        }
    }
}
