using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menü_Umrandung
{
    
    public class Umrandung1
    {
        public void Menü (String[] text)
        {
            // 0 ) Umrandung einstelen ##################################

            String linkerRand  = "##  ";    // So wird der Linke Rand später aussehen
            String rechterRand = "  ##";    // So wird der Rechte Rand später aussehen
            String Balken      = "#";       // So wird der Obere & Untere Rand später aussehen
            String Balken2 = Balken;        // Erzeugt für Punkt    // 3)   wichtig   

            String str = "";                // Erzeugt worden, um die Länge eines Strings im text[] array abzufragen
            //String leerzeichen = " ";       // Erzeugt für Punkt    // 2,5)   wichtig   

            int[] zeichenanzahl = new int[text.Length];      // Die Länge jedes Strings im text[] array wird heir gespeichert 
            int längsterString  = 0;                         // Der Längste String wird hier die zeichenanzahl gespeichert

            // Gibt die größe des neuenText[] Arrays an, der mit dem linken und rechten Rand ausgestatet wird
            int neuerTextLänge = linkerRand.Length + text.Length + rechterRand.Length;  
            String[] neuerText = new String[text.Length];    // Das muss man irgendiwe anders gehen, vielleicht im nächstem versuch mit einer liste oder so...


            // 1) Fügt im neuenText[] array erst den Linken rand, dann den String im text[] array und dann den rechten rand hinzu ##################################
            
            for (int i = 0; i < text.Length; i++)   // Arraygröße des übergebenen text[] arrays 
            {
                neuerText[i] = linkerRand + text[i] + rechterRand; 
            }


            // 2) Die größe der einzelnen Strings im neuerText[] array wird ermitteln ##################################
            
            for (int i = 0; i < neuerText.Length; i++)
            {
                str = neuerText[i];                // neuertext str zugweisen, um die text länge zu erfahren 
                zeichenanzahl[i] = str.Length;     // die textlänge im array gespeichert

                if (str.Length > längsterString)   // Die größte Zeichen Läenge wird ermittelt zu bestimmung der balken
                {
                    längsterString = str.Length;
                }
            }


            // 2,5 )  Den kleineren String Leerzeichen hinzufügen, damit der rechte Rand am Rand ist

            for (int i = 0; i < neuerText.Length; i++)
            {
                int differenz = längsterString - zeichenanzahl[i]; // Die Differnez soll als Leerzeichen angehangen werden
                String leerzeichen = "";
                while (differenz > 0)
                {
                    leerzeichen += "2";
                    differenz -= 1;
                }

                String auslage = neuerText[i];  // String Array in auslage auslagern # LoL
                int charWert   = auslage.IndexOf(rechterRand);   // den char als zahl gespeichert, der position des anfangs von dem String "rechter rand"   
                neuerText[i] = auslage.Insert(charWert, leerzeichen); // noch befor der rechte rand gebinnt, werden die leerzeichen hinzugefügt  
     
            }

            // 3) Anhand der (int längsterString  = 0) werden der obere & untere rand/Balken ermittelt  ##################################
            Balken = "";
            for (int i = 0; i < (längsterString); i++) // -1 weil oben schon angegeben
            {
                Balken += Balken2;  // Balken = "#"  also Balken+Balken ist ##... o__O
            }


            // 4) Asuage des eingerahmten text[]array Menü ##################################

            Console.WriteLine(Balken);
            foreach (String aa in neuerText)
            {
                Console.WriteLine(aa);
            }
            Console.WriteLine(Balken);
        }

    }
}
