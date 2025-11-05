using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KrigSpil : Spil
{
    private Bunke bunke;

    public KrigSpil()
    {
        Navn = "Krig";
        Kategori = "Klassiske";
        Beskrivelse = "Hver spiller vender 1 kort. Højeste vinder (Es højest).";
        MinSpillere = 2;
        MaxSpillere = 2;
        bunke = new Bunke();
    }
    public override void SpilRunde()
    {
        bunke.Reset();
        bunke.Bland();// Bland kortene før hver runde

        Kort a = bunke.Træk();// Spiller 1 trækker kort
        Kort b = bunke.Træk();// Spiller 2 trækker kort

        Console.WriteLine("Spiller 1: " + a);
        Console.WriteLine("Spiller 2: " + b);

        int va = Bunke.VærdiSomTal_Krig(a.Værdi);
        int vb = Bunke.VærdiSomTal_Krig(b.Værdi);

        if (va > vb) Console.WriteLine("Resultat: Spiller 1 vinder");// Sammenligner kortværdierne
        else if (vb > va) Console.WriteLine("Resultat: Spiller 2 vinder");
        else Console.WriteLine("Resultat: Uafgjort");

        Console.WriteLine();

    }


}