using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SurpriseMe
{
    // Superklasse
    abstract class Kortspil
    {
        public abstract void StartSpil();
    }

    // Underklasser
    class blackjack : Kortspil
    {
        public override void StartSpil()
        {
            Console.WriteLine("Du spiller nu Spil 1 - blackjack!");
        }
    }

    class farveduel : Kortspil
    {
        public override void StartSpil()
        {
            Console.WriteLine("Du spiller nu Spil 2 - farveduel!");
        }
    }

    class krig : Kortspil
    {
        public override void StartSpil()
        {
            Console.WriteLine("Du spiller nu Spil 3 - krig!");
        }
    }

    // SurpriseMe klasse
    class SurpriseMe
    {
        private List<Kortspil> spilListe = new List<Kortspil>
        {
            new blackjack(),
            new farveduel(),
            new krig()
        };

        private Random random = new Random();

        public void VælgTilfældigtSpil()
        {
            int index = random.Next(spilListe.Count); // vælg random mellem 0, 1 eller 2
            Kortspil valgtSpil = spilListe[index];

            Console.WriteLine("Surprise! Et spil er valgt for dig...");
            valgtSpil.StartSpil();
        }
    }

    // Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tryk ENTER for 'Surprise Me'!");
            Console.ReadLine();

            SurpriseMe surprise = new SurpriseMe();
            surprise.VælgTilfældigtSpil();

            Console.WriteLine("\nTryk ENTER for at spille spil.");
            Console.ReadLine();
        }
    }
}

