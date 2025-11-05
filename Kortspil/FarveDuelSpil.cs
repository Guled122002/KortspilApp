using System;

class FarveDuelSpil : Spil
{
    private static string[] Kulører = { "Spar", "Hjerter", "Ruder", "Klor" };
    private static string[] Værdier = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knaegt", "Dame", "Konge", "Es" };
    private Random rnd = new Random();

    public FarveDuelSpil()
    {
        Navn = "Farve Duel";
        Kategori = "Hjernetraening";
        Beskrivelse = "Træk to kort – højeste farve vinder (Spar > Hjerter > Ruder > Klor). Ved lighed bruges kortværdi.";
        MinSpillere = 2;
        MaxSpillere = 4;
    }
    private Kort TilfaeldigtKort()
    {
        string k = Kulører[rnd.Next(Kulører.Length)];
        string v = Værdier[rnd.Next(Værdier.Length)];
        return new Kort(k, v);
    }

    private int FarveRank(string kulor)
    {
        if (kulor == "Spar") return 3;
        if (kulor == "Hjerter") return 2;
        if (kulor == "Ruder") return 1;
        return 0; // Klor
    }

    public override void SpilRunde()
    {
        Kort a = TilfaeldigtKort();
        Kort b = TilfaeldigtKort();

        Console.WriteLine("Kort A: " + a);
        Console.WriteLine("Kort B: " + b);

        int ra = FarveRank(a.Kulør);// Sammenligner kortfarverne
        int rb = FarveRank(b.Kulør);

        if (ra > rb) Console.WriteLine("Resultat: A vinder på farve");
        else if (rb > ra) Console.WriteLine("Resultat: B vinder på farve");
        else
        {
            int va = Bunke.VærdiSomTal_Krig(a.Værdi);// Sammenligner kortværdierne ved lighed i farve
            int vb = Bunke.VærdiSomTal_Krig(b.Værdi);
            if (va > vb) Console.WriteLine("Resultat: A vinder på værdi");
            else if (vb > va) Console.WriteLine("Resultat: B vinder på værdi");
            else Console.WriteLine("Resultat: Uafgjort");
        }
        Console.WriteLine();
    }
}
