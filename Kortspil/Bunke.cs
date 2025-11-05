using System;
using System.Collections.Generic;

class Bunke
{
    private List<Kort> kort = new List<Kort>();

    // Kulører og værdier på kortene
    private static string[] kulører = { "Spar", "Hjerter", "Ruder", "Klør" };
    private static string[] værdier = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knægt", "Dame", "Konge", "Es" };

    private Random tilfældigt = new Random();

    
    public Bunke()
    {
        Reset();
    }

    public void Reset()
    {
        kort.Clear();
        for (int i = 0; i < kulører.Length; i++)
        {
            for (int j = 0; j < værdier.Length; j++)
            {
                kort.Add(new Kort(kulører[i], værdier[j]));
            }
        }
    }

   
    public void Bland()
    {
        for (int i = kort.Count - 1; i > 0; i--)
        {
            int j = tilfældigt.Next(i + 1);
            Kort temp = kort[i];
            kort[i] = kort[j];
            kort[j] = temp;
        }
    }

 
    public Kort? Træk()
    {
        if (kort.Count == 0) return null;
        Kort k = kort[0];
        kort.RemoveAt(0);
        return k;
    }


   
    public int Antal()
    {
        return kort.Count;
    }

    public static int VærdiSomTal_Krig(string v)
    {
        if (v == "Knægt") return 11;
        if (v == "Dame") return 12;
        if (v == "Konge") return 13;
        if (v == "Es") return 14;
        return int.Parse(v);
    }

   
    public static int VærdiSomTal_21(string v)
    {
        if (v == "Knægt" || v == "Dame" || v == "Konge") return 10;
        if (v == "Es") return 11; // light-version (ingen 1/11-justering)
        return int.Parse(v);
    }
}

