﻿using System.Xml.Linq;

namespace abc{
    class Program {
        public static void Main(string[] args) {
     

            //CAMBEstand klasse  field   instructiebestand string    toon instructie
            CAMBestand cmbestand = new CAMBestand();
            cmbestand.instructietext = "ffzagen;hakken4cm;";
            cmbestand.toonInhoud();
            Auto a = new Auto("Audi");
            new Auto("Audi");
            Auto b = new Auto("Mercedes");
            Console.WriteLine(a.merk);
            Console.WriteLine(b.merk);
            b.setSnelheid(-48);
            b.toonSnelheid();
            b.AantalPersonen = -3;
            Console.WriteLine(b.AantalPersonen);
        }
    }
    class Auto {
        internal string merk;
        private int snelheid;
        private int aantalPersonen;

        public int AantalPersonen {
            get { return aantalPersonen; }
            set {
                if (value < 0) {
                    Console.WriteLine("Schande");
                }
                else
                {
                    aantalPersonen = value;
                }
            }
        }

        public void setSnelheid(int speed) {
            if (speed < 0)
            {
                Console.WriteLine("doe niet zo raar");
            }
            else
            {
                snelheid = speed;
            }
        }
        public void toonSnelheid() {
            Console.WriteLine(snelheid);
        }
        public Auto(string brand) {
            Console.WriteLine("er wordt een auto gemaakt");
            merk = brand;
        }
    
    }

}
