using System;
namespace Yatzy_spil
{
    public class Bæger
    {
        public Terning terning1 = new Terning(); //opretter objekt af typen terning fra terning klassen - vi new'er terning klassen op til en ny type
        public Terning terning2 = new Terning(); //(fortsat) metoden bliver aktiveret og vi får et nyt objekt
        public Terning terning3 = new Terning(); //(fortsat) vi vil have en nye variabel som hedder terning1 - den skal indeholde objekter fra terningklassen
        public Terning terning4 = new Terning();
        public Terning terning5 = new Terning();

        public void RystBaeger() //ny metode 
        { /*vi har lige oprettet 5 terninger af typen terning fra terningklassen. 
        KastTerning er en metode fra terningklassen, som vi kalder frem her, for at bruge den på alle terningerne, så vi får en ny metode der ryster bægeret med alle terningerne */
            terning1.KastTerning();
            terning2.KastTerning();
            terning3.KastTerning();
            terning4.KastTerning();
            terning5.KastTerning();
        }

    }

}
