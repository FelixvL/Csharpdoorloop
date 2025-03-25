using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace abc
{
    internal class CAMBestand
    {
        internal string instructietext;

        internal string bestandsnaam;

        public CAMBestand(string hout){
            bestandsnaam = hout;
            instructietext = File.ReadAllText(hout);
            Console.WriteLine("Er is een cambestand aangemaakt: "+hout);
        }

        internal void toonInhoud() {
            Console.WriteLine("Inhoud file: "+ bestandsnaam +" \n"+instructietext);
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine();
        }
        internal void schrijfBestand() {
            File.WriteAllText(bestandsnaam, instructietext); 
            Console.WriteLine("======"+ bestandsnaam + "=== beschreven ==");
        }
        internal void VoegInstructieToe() {
            Console.WriteLine("+++++++++\nHuidige Inhoud:");
            Console.WriteLine(instructietext);
            Console.WriteLine("Voer in: ");
            String instructie = Console.ReadLine();
            instructietext += "\n"+instructie;
            Console.WriteLine("Nieuwe Inhoud:");
            Console.WriteLine(instructietext);
            Console.WriteLine("+++++++++\n");
        }
    }
}
