using System;
namespace Yatzy_spil
{

    public class Muligheder
    {
        public Bæger baegerMuligheder = new Bæger(); //opretter nyt instans af typen bæger, så vi kan bruge terningerne i denne klasse. Nedarver ikke!

        private int HvorMangeAfEnSlags(int slags) //opretter en metode til at finde ud af hvor mange terninger der er ens. i () er "slags" defineret som en int varibel, som senere kan skiftes ud med et tal
        {
            int antal = 0;

            if (baegerMuligheder.terning1.Oejne == slags) //tjekker / sammenligner om terning1 er lig med det tal vi nu vil tjekke. 1'ere hvis nu vi havde sat "1" i slags
            { antal = antal + 1; } //hvis terning1 = det tal vi vil tjekke (fx 1'ere), så tæller den 1 op.
            if (baegerMuligheder.terning2.Oejne == slags)
            { antal = antal + 1; } //osv. ned af.
            if (baegerMuligheder.terning3.Oejne == slags)
            { antal = antal + 1; }
            if (baegerMuligheder.terning4.Oejne == slags)
            { antal = antal + 1; }
            if (baegerMuligheder.terning5.Oejne == slags)
            { antal = antal + 1; } //husk at "antal" ændrer sig på vej ned i koden

            return antal; //hvis nu der fx var 3 1'ere, så ville den returne "3" (hvis vi skulle tjekke 1'erne)
        }

        //Hvor mange af en slags 1-6:

        public int SumEttere() //I nedenstående sætter vi så en variabel / parameter (1-6) ind i metoden HvorMangeAfEnSlags, for at tjekke alle mulighederne
        {
            return HvorMangeAfEnSlags(1) * 1; //return hvor mange 1'ere der er og summen af dem
        }

        public int SumToere()
        {
            return HvorMangeAfEnSlags(2) * 2; //return hvor mange 2'ere der er og summen af dem
        }

        public int SumTreere()
        {
            return HvorMangeAfEnSlags(3) * 3;
        }

        public int SumFiere()
        {
            return HvorMangeAfEnSlags(4) * 4;
        }

        public int SumFemmere()
        {
            return HvorMangeAfEnSlags(5) * 5;
        }

        public int SumSeksere()
        {
            return HvorMangeAfEnSlags(6) * 6;
        }

        //Par

        public int SumEtPar() //metode til at finde summen af et par
        { //bruger for-loop, sætter i til 6 fordi vi vil have det højeste par. Så den starter ved 6
            for (int flow = 6; flow >= 1; --flow) //i går 1 ned hver gang loopet bliver kørt. Så længe i er større end eller lig med 1, så kører loopet
            { //hvis den så finder et par - ved at se om HvorMangeAfEnSlags er større end 1
                if (HvorMangeAfEnSlags(flow) > 1)
                { return flow * 2; } //så udregnes pointene af parret
            }
            return 0; //hvis den går hele vejen igennem til den når under 1, så returnere den 0 - fordi der ikke var nogle point
        }

        public int SumToPar()  
        {
            int foerstePar = 0;
            int andetPar = 0;

            for (int flow = 6; flow >= 1; --flow)
            {
                if (HvorMangeAfEnSlags(flow) > 1)
                {
                    if (foerstePar == 0)
                    {
                        foerstePar = flow * 2;
                    }
                    else
                    {
                        andetPar = flow * 2;
                        return foerstePar + andetPar;
                    }
                }
            }
            return 0;
        }


        //3 og 4 ens

        public int SumTreEns()
        {
            for (int flow = 6; flow >= 1; --flow)
            {
                if (HvorMangeAfEnSlags(flow) > 2)
                { return flow * 3; }
            }
            return 0;
        }

        public int SumFireEns()
        {
            for (int flow = 6; flow >= 1; --flow)
            {
                if (HvorMangeAfEnSlags(flow) > 3)
                { return flow * 4; }
            }
            return 0;
        }

        //Straight

        public int SumLilleStraight()
        {
            if (SumEtPar() > 1 || HvorMangeAfEnSlags(6) == 1) 
            { return 0; }

            return 15;
        }


        public int SumStorStraight()
        {
            if (SumEtPar() > 1 || HvorMangeAfEnSlags(1) == 1)
            { return 0; }

            return 20;
        }

        //Fuldt Hus
        public int SumFuldtHus()
        {
            int pointTreEns = 0; //lokal variabel som vi definerer
            int pointToEns = 0;

            for (int flow = 6; flow >= 1; --flow)
            {
                if (HvorMangeAfEnSlags(flow) == 3) //tjekker for 3 ens
                {
                    if (pointToEns == 0)
                    {
                        pointTreEns = flow * 3;
                    }
                    else
                        return pointToEns + flow * 3;
                }
                else if (HvorMangeAfEnSlags(flow) == 2)
                {
                    if (pointTreEns == 0)
                    {
                        pointToEns = flow * 2;
                    }
                    else
                        return pointTreEns - flow * 2;
                }
            }
            return 0;
        }

        //Yatzy
        public int SumYatzy()
        {
            for (int flow = 6; flow >= 1; --flow)
            {
                if (HvorMangeAfEnSlags(flow) == 5)
                { return flow * 5 + 50; }
            }
            return 0;
        }

        //Chance
        public int SumChance()
        {
            return baegerMuligheder.terning1.Oejne + baegerMuligheder.terning2.Oejne + baegerMuligheder.terning3.Oejne + baegerMuligheder.terning4.Oejne + baegerMuligheder.terning5.Oejne;
        }
    }

}

