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

            Machine m = new FreesMachine();
            m.Serienummer = "Frees8342";
            m.huidigBestand = camfrasenkl2;
            m.uitvoeren();
            Reparateur ronald = new Reparateur();
            ronald.repareren(m);

        }


    
    }
    class Reparateur {
        public void repareren(Machine m) {
            Console.WriteLine("FIXEN"+m.Serienummer);
        }
    }

}
