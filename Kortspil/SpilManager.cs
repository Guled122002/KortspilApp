using System;
using System.Collections.Generic;

class SpilManager
{
    // Samling af alle spil
    public List<Spil> SpilListe = new List<Spil>();

    // Antal spillere (bruges kun til at vise/filtrere)
    public int AntalSpillere = 2;

    private Random rnd = new Random();

    public SpilManager()
    {
        // Opret de spil klassediagram viser
        SpilListe.Add(new KrigSpil());
        SpilListe.Add(new BlackjackSpil());
        SpilListe.Add(new FarveDuelSpil());
    }

    public void VisAlleSpil()
    {
        Console.WriteLine(" Tilgængelige spil ");
        for (int i = 0; i < SpilListe.Count; i++)
        {
            Spil s = SpilListe[i];
            Console.WriteLine("- " + s.Navn + " (" + s.Kategori + ")");
        }
        Console.WriteLine();
    }

    public Spil? FindSpil(string navn) // 
    {
        if (navn == null) return null;

        for (int i = 0; i < SpilListe.Count; i++) // Gennemløber alle spil
        {
            if (string.Equals(SpilListe[i].Navn, navn, StringComparison.OrdinalIgnoreCase))
                return SpilListe[i];
        }
        return null;
    }

    
    public Spil? SurpriseMe(string? kategori) // vælger et tilfældigt spil
    {
        List<Spil> egnede = new List<Spil>();

        for (int i = 0; i < SpilListe.Count; i++)
        {
            Spil s = SpilListe[i];
            bool kategoriOk = (kategori == null) || (s.Kategori == kategori);
            bool antalOk = (AntalSpillere >= s.MinSpillere && AntalSpillere <= s.MaxSpillere);

            if (kategoriOk && antalOk)
                egnede.Add(s);
        }

        if (egnede.Count == 0) return null;

        int index = rnd.Next(egnede.Count);
        return egnede[index];
    }
}
