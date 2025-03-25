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
