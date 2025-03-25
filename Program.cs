using System.Xml.Linq;

namespace abc{
    class Program {
        public static void Main(string[] args) {
            CAMBestand camzagenkl1 = new CAMBestand("houtzagen.txt");
            camzagenkl1.instructietext = "ffzagen;hakken4cm;";
            camzagenkl1.toonInhoud();
            CAMBestand camfrasenkl2 = new CAMBestand("frasen.txt");
            camfrasenkl2.instructietext = "freezen;schuur2cm;";
            camfrasenkl2.toonInhoud();
        }
    
    
    }

}
