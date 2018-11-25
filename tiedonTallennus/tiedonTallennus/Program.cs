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
            int lampotila = 0;
            Console.Write ("Anna uusi lämpötila: ");
            string syote = Console.ReadLine();
            lampotila = int.Parse(syote);

            // tiedostoon kijroittaminen
            string tiedosto = @"C:\Temp\Lampotila.txt";
            File.WriteAllText(tiedosto, lampotila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu!");

            Console.ReadLine();
        }
    }
}
