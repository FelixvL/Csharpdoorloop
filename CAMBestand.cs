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
            Console.WriteLine("er is een cambestand aangemaakt");
        }

        internal void toonInhoud() {
            Console.WriteLine(instructietext);
        }
    }
}
