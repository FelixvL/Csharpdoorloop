using System.Reflection.PortableExecutable;
using System.Xml.Linq;
// Is a      Inheritance  Overerving
// Has a          aggregaat compositie
namespace abc{
    class Program {
        public static void Main(string[] args) {
            CAMBestand camzagenkl1 = new CAMBestand("houtzagenkl1.txt");
            camzagenkl1.toonInhoud();
            CAMBestand camfrasenkl2 = new CAMBestand("freezenkl2.txt");
            camfrasenkl2.toonInhoud();


            camzagenkl1.VoegInstructieToe();
            camzagenkl1.VoegInstructieToe();
            camfrasenkl2.VoegInstructieToe();

            camzagenkl1.schrijfBestand();
            camfrasenkl2.schrijfBestand();

            Machine m = new FreesMachine();
            m.huidigBestand = camfrasenkl2;
            m.uitvoeren();

        }


    
    }

}
