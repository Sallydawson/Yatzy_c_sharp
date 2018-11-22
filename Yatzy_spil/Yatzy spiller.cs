using System;
namespace Yatzy_spil
{
    public class Yatzy_spiller
    {
        public string Name { get; set; } //PROPERTIES (egenskaber) en spiller kan få et navn og sætte et navn
        public Muligheder SpillerMuligheder { get; set; } = new Muligheder(); //giver hver spiller et sæt af muligheder


    }
}
