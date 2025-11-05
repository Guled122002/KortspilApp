using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Kort
{
    public string Kulør = "";
    public string Værdi = "";

    public Kort(string kulør, string værdi)
    {
        Kulør = kulør;
        Værdi = værdi;
    }

    public override string ToString()
    {
        return Værdi + " af " + Kulør;
    }
}
