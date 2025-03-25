using System.Xml.Linq;
// Is a      Inheritance  Overerving
// Has a          aggregaat compositie
namespace abc{
    class Program {
        public static void Main(string[] args) {
            CAMBestand camzagenkl1 = new CAMBestand("houtzagenkl1.txt");
            camzagenkl1.instructietext = "ffzagen;hakken4cm;";
            camzagenkl1.toonInhoud();
            CAMBestand camfrasenkl2 = new CAMBestand("freezenkl2.txt");
            camfrasenkl2.instructietext = "freezen;schuur2cm;";
            camfrasenkl2.toonInhoud();

            Persoon p = new Persoon();
            p.Voornaam = "fred";
            p.mijnTelefoon = new Telefoon();
            p.mijnTelefoon.Merk = "Android";
            p.voorstellen();
            Telefoon t = new Telefoon();
            t.Merk = "Iphone";
            p.mijnTelefoon = t;
            p.voorstellen();
            Dier d = new Konijn();
            Konijn k = new Konijn();
            k.lengteknaagtand = 4;
            k.hartslag = 25;
            k.voortbewegen();

        }


        class Dier {  // base klasse super klasse  parent class
            public int hartslag;
            public void voortbewegen() {
                Console.WriteLine("voortbewegen in dier");
            }
        }
        class Konijn : Dier { // Is a relatie   subklasse child class
            public int lengteknaagtand;
        }


        class Telefoon {
            public String Merk { get; set; }
        }

        class Persoon { 
            public String Voornaam { get; set; }
            public Telefoon mijnTelefoon;
            public void voorstellen() {
                Console.WriteLine("hoi ik ben " + Voornaam + " en ik heb een " + mijnTelefoon.Merk);
            }
            
        }



 // Konijn DIer ja   richting van konijn naar dier
 // Konijn Konijn
 // Dier  Konijn mischien ligt eraan
 // Konijn OlieTanker nee
    
    }

}
