using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menü_Umrandung
{
    class Program
    {
        static void Main(string[] args)
        {
            Menü();           
        }

        static void Menü()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;

            int zahlZahleZahl1 = 1;
            Int64 zahlZahleZahl2 = 2222222222222222221;

            String[] text1 = 
                {
                "1) Auswahl",
                "2) Auswahl für",
                "3) Auswahl für das",
                "4) Auswahl für das die Klasse",
                "",
                "Nur Texte verfassen, keine Menüanpassungen mehr",
                "Menürahmen passt sich der TExtgröße an",
                "Menürahmen sind nun editierbar",
                "",
                "acb "
                };

            String[] text2 =
                {
                "abc",
                "abc " + zahlZahleZahl1,
                "abc " + zahlZahleZahl2
                };

            Umrandung2 lol = new Umrandung2();
            lol.Menü(text1);
            lol.Menü(text2);

            /*// Test
            Console.WriteLine("Das geht\n\n");

            String original1 = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original1);
            String modified1 = original1.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified1);

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Das geht nicht \n\n");

            String original2 = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original2);
            String modified2 = original2;
            modified2 = modified2.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified2);
            // Test




            //foreach (String i in text)
            //{
            //    Console.WriteLine(i);
            //}
            */


            Console.ReadLine();
        }

    }
}
