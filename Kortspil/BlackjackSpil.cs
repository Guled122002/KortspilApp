using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BlackjackSpil : Spil
{
    private Bunke bunke;

    public BlackjackSpil()
    {
        Navn = "21 (Blackjack)";
        Kategori = "Klassiske";
        Beskrivelse = "Simpel demo: 2 kort til spiller og dealer. Højeste sum ≤ 21 vinder.";
        MinSpillere = 1;
        MaxSpillere = 4;
        bunke = new Bunke();
    }
    private int Score(Kort k1, Kort k2) // beregner kortværdi for 2 kort
    {
        return Bunke.VærdiSomTal_21(k1.Værdi) + Bunke.VærdiSomTal_21(k2.Værdi);
    }

    public override void SpilRunde()
    {
        bunke.Reset();
        bunke.Bland();

        Kort p1a = bunke.Træk(); Kort p1b = bunke.Træk();
        Kort dea = bunke.Træk(); Kort deb = bunke.Træk();

        int ps = Score(p1a, p1b);
        int ds = Score(dea, deb);

        Console.WriteLine("Spiller: " + p1a + ", " + p1b + " = " + ps);
        Console.WriteLine("Dealer : " + dea + ", " + deb + " = " + ds);
        string res;
        if (ps > 21 && ds > 21) res = "Begge buster (uafgjort)"; // begge bust
        else if (ps > 21) res = "Spiller buster (dealer vinder)";// spiller bust
        else if (ds > 21) res = "Dealer buster (spiller vinder)";
        else if (ps > ds) res = "Spiller vinder";
        else if (ds > ps) res = "Dealer vinder";
        else res = "Uafgjort";

        Console.WriteLine("Resultat: " + res); // viser resultat
        Console.WriteLine();
    }
}

  
