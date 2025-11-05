using System;

class Program
{
    static void Main()
    {

        SpilManager manager = new SpilManager();// Opretter spilmanager 

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Kortspils-app ===");
            Console.WriteLine("Antal spillere: " + manager.AntalSpillere);
            Console.WriteLine("1) Vis alle spil");
            Console.WriteLine("2) Start et spil (skriv navn)");
            Console.WriteLine("3) Surprise me");
            Console.WriteLine("4) Skift antal spillere");
            Console.WriteLine("5) Afslut");
            Console.Write("Valg: ");
            string valg = Console.ReadLine();
            Console.WriteLine();

            if (valg == "1") // Tjekkes hvad brugeren har valgt
            {
                manager.VisAlleSpil();
            }
            else if (valg == "2")
            {
                Console.Write("Skriv spilnavn (Krig / 21 (Blackjack) / Farve Duel): ");
                string navn = Console.ReadLine();
                Spil s = manager.FindSpil(navn);
                if (s != null) // viser regler og starter spillet hvis spillet findes
                {
                    s.VisRegler();
                    s.SpilRunde();
                }
                else
                {
                    Console.WriteLine("Spillet blev ikke fundet.");
                }
            }
            else if (valg == "3")
            {
                Spil s = manager.SurpriseMe(null); // alle kategorier
                if (s != null)
                {
                    Console.WriteLine("Surprise me valgte: " + s.Navn);
                    s.VisRegler();
                    s.SpilRunde();
                }
                else
                {
                    Console.WriteLine("Ingen egnede spil fundet.");
                }
            }
            else if (valg == "4")
            {
                Console.Write("Nyt antal spillere: ");
                string t = Console.ReadLine();
                int n;
                if (int.TryParse(t, out n) && n > 0) manager.AntalSpillere = n;
            }
            else if (valg == "5")
            {
                Console.WriteLine("Farvel!");
                break;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg.");
            }

            Console.WriteLine("Tryk Enter for at fortsætte..");
            Console.ReadLine();
        }
    }
}
