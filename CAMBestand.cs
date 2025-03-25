using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class CAMBestand
    {
        internal string instructietext;

        internal string bestandsnaam;

        public CAMBestand(string hout){
            bestandsnaam = hout;
            Console.WriteLine("Er is een cambestand aangemaakt: "+hout);
        }

        internal void toonInhoud() {
            Console.WriteLine("Inhoud file: "+ bestandsnaam +" \n"+instructietext);
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine();
        }
    }
}
