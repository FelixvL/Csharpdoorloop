using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace abc{
    class Program {
        public static void Main(string[] args) {
            CAMBestand camzagenkl1 = new CAMBestand("houtzagenkl1.txt");
            camzagenkl1.toonInhoud();
            CAMBestand camfrasenkl2 = new CAMBestand("freezenkl2.txt");
            camfrasenkl2.toonInhoud();
            CAMBestand camfrasenkl3 = new CAMBestand("freezenkl3.txt");
            camfrasenkl3.toonInhoud();

            camzagenkl1.VoegInstructieToe();
            camzagenkl1.VoegInstructieToe();
            camfrasenkl2.VoegInstructieToe();

            camzagenkl1.schrijfBestand();
            camfrasenkl2.schrijfBestand();

            FreesMachine m = new FreesMachine();
            m.MesLeverancier = "Kees";
            m.Serienummer = "Frees8342";
            m.huidigBestand = camfrasenkl2;
            m.uitvoeren();

            int[] getall = new int[6];
            Machine[] machines = new Machine[6];
            machines[0] = new FreesMachine();
            
            Reparateur ronald = new Reparateur();
            ronald.repareren(m);
            Trap t1 = new Trap();
            WentelTrap t2 = new WentelTrap();
            Console.Write(Trap.a);
            
            t2.b = 8;

            t1.toonTrap();
            t2.toonTrap();


        }
    }
    class Trap {
        public const int a = 5;

        public void toonTrap() {
            Console.WriteLine("" + a + "");
        }
    }
    class WentelTrap : Trap {
        public int b;
        public void toonTrap()
        {
            Console.WriteLine("" + a + ""+b);
        }
    }




    class Reparateur {
        public void repareren(Machine m) {
           // m.MesLeverancier = "Kees";
            Console.WriteLine("FIXEN"+m.Serienummer);
        }
    }

}
