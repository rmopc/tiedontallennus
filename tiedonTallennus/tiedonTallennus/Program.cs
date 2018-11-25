using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Lampotila.txt";
            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on " + aiempiArvo + " astetta.");
            }
            else
            {
                Console.WriteLine("Terve ja moro!");
            }

            int lampotila = 0;
            Console.Write ("Anna uusi lämpötila: ");
            string syote = Console.ReadLine();
            lampotila = int.Parse(syote);

            // tiedostoon kijroittaminen
            File.WriteAllText(tiedosto, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu!");

            Console.ReadLine();
        }
    }
}
