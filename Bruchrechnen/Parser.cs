/*****************************************************************************
h e i n r i c h -h e r t z -b e r u f s k o l l e g  d e r  s t a d t  b o n n
Autor:			Evgeny Degtyarev
Klasse:			IA116
Datum:			30.05.2017
Datei:			Parser.cs
Einsatz:		run.cs
Beschreibung:	Ein Parser zur Fehlerbehandlung von ungueltigen Eingaben, zum
 *              Beispiel im Falle von Buchstabeneingaben.
Funktionen:		public static int parser(String data, int status)
******************************************************************************
Aenderungen:
30.05.2017:     Beginn
12.06.2017:     Angleichung Parser an Programmkriterien (Arbeit mit Bruechen)
13.06.2017:     Anpassungen bzgl. ungueltiger Brueche 
 *              (z.B. Teilen durch 0 sowie Fehlerbehandlung)
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
        //  data = String zum parsen
        //  status = Zaehler(1) oder Nenner(2) Unterscheidung
        public static int parser(String data, int status)
        {
            String pData = data + "#";
            String newData = "";
            bool valid = true;
            String id = "";

            int x = 0;
            while (pData[x] != '#')
            {
                if ((pData[x] != '1') && (pData[x] != '2') && (pData[x] != '3') && (pData[x] != '4')
                     && (pData[x] != '5') && (pData[x] != '6') && (pData[x] != '7') && (pData[x] != '8') && (pData[x] != '9')
                    && (pData[x] != '0') && (pData[x] != '-'))
                {
                    valid = false;
                }
                else
                {
                    newData = newData + pData[x];
                }
                x++;
            }

            if (newData == "")
            {
                newData = "1";
            }
            else
            {
            }

            if (!valid)
            {
                Console.WriteLine("");
                Console.WriteLine("Die eingegebene Zahl '" + data + "' enthaelt unerlaubte Zeichen.");
                Console.WriteLine("- Meinten Sie '" + newData + "' ? -");
                Console.WriteLine(" (0) - JA.");
                Console.WriteLine(" (1) - NEIN.");

                id = Console.ReadLine();
                if (id == "0")
                {

                }
                else if (id == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Bitte erneut eingeben:");
                    Double temp = 0;
                    temp = parser(Console.ReadLine(), status);
                    newData = Convert.ToString(temp);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Menuepunkt " + id + " gibt es nicht. Bitte erneut..");
                    Console.ReadLine();
                    Double temp = 0;
                    temp = parser(data, status);
                    newData = Convert.ToString(temp);
                }
            }
            else
            {
            }

            if (data.Equals("0") && status == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("'" + data + "' fuer Nenner ist nicht erlaubt.");
                Console.WriteLine("");
                Console.WriteLine("Bitte erneut eingeben:");
                Double temp = 0;
                temp = parser(Console.ReadLine(), status);
                newData = Convert.ToString(temp);
            }
            else
            {
            }

            if (newData.Contains('-')) 
            {
                newData = newData.Replace("-", String.Empty);
                newData = "-" + newData;
            }
            else
            {
            }

            return Convert.ToInt32(newData);
        }
    }
}

