using System;
namespace Yatzy_spil
{
    public class Terning //privat på klasse-niveau - klassen kan bruges inde i projektet
    {
        private int antalOejne; //vi definerer varibel (en field) af datatypen int (heltal uden decimaler)
        private Boolean holdDen = false; //definerer en variabel af typen boolean og giver den navnet holdMig. Når holdMig er false, går vi videre til nyt random tal. Sætter den til false, da det er her man generer en nyt tal (terning)
        private static Random tilfældigtTal = new Random(); //varibel af typen random, kalder den r, som vi bruger til at gemme et tilfældigt i.

        public int Oejne //opretter en ny varibel (en property) som kan bruges i andre klasser. Oejne returnerer indholdet af variblen antalOejne, værdien heri kan ikke ændres fordi antalOejne er privat
        {
            get { return antalOejne; } // får / returner / henter værdien i antalOejne - kan kun aflæse, ikke ændre når det er "get" - fordi man skal ikke kunne snyde
        }

        public Boolean Holdt //opretter variabel af typen boolean, giver navnet Holdt
        {
            get { return holdDen; } // får / returner / henter værdien i holdMig som kan være sandt eller falsk
        }

        public void KastTerning() //opretter metode, void = KastTerning tager imod en værdi, gør noget med den, men returnerer ikke nogen værdi - den eneste måde man kan ændre værdien af terning
        {
            if (holdDen == false) //sammenligner om holdMig er det samme som false
            { antalOejne = tilfældigtTal.Next(1, 7); } //hvis holdMig er det samme som false, så bliver antalOejne sat til et tilfældigt tal mellem 1 og 7 (7 tælles ikke med) 
        }

        public void HoldTerning() //opretter samme slags metode
        {
            holdDen = true; //hvis holdDen modsat ovenover er true, så generes der ikke nyt tal som ovenstående, men den bliver bare sat til true og holdes
        }

        public void TagTerningMed() //opretter metode igen
        {
            holdDen = false; //sætter holdDen til false. hvis holdDen har været true men bliver sat til false, så den kan blive kastet igen
        }
    }
}
