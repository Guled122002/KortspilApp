using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Spil
{
    public string Navn = "";
    public string Kategori = "";
    public string Beskrivelse = "";
    public int MinSpillere;
    public int MaxSpillere;
 


    public virtual void VisRegler()
    {
        System.Console.WriteLine("Spil" + Navn);
        System.Console.WriteLine("Kategori" + Kategori);
        System.Console.WriteLine("Spillere" + MinSpillere + "-" + MaxSpillere);
        System.Console.WriteLine();


    }
    public abstract void SpilRunde();
}