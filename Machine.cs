using abc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Machine
    {
        public String Serienummer { get; set; }
        internal CAMBestand huidigBestand;

        internal void uitvoeren() {
            Console.WriteLine("Ik machine: "+Serienummer);
            Console.WriteLine("Verwerk " + huidigBestand.instructietext);
        }
    }
}
