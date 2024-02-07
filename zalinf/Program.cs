namespace zalinf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Ksiazka ksiazka = new Ksiazka("Wiedzmin", "Andrzej Sapkowski", 1993);

            Ksiazka ksiazka2 = new Ksiazka("Anaruk: Chłopiec z Grenlandii", "Bohdan Butenko", 1962);

            Ksiazka ksiazka3 = new Ksiazka("Gwiezde Wojny: Nowa Nadzieja", "George Lucas", 1977);

            ksiazka.WyswietlInfo();
            ksiazka2.WyswietlInfo();
            ksiazka3.WyswietlInfo();

            // Zainicjuj liste ksztaltow
            List<Ksztalt> ksztalty = new List<Ksztalt>();
            ksztalty.Add(new Prostokat(2, 3));
            ksztalty.Add(new Trojkat(3, 4));
            ksztalty.Add(new Kolo(5));
            ksztalty.Add(new Prostokat(4, 5));

            // Wypisz pole ksztalow dla obowodow wiekszych niz 10
            Console.WriteLine("Pola ksztaltow dla obowodow wiekszych niz 10: ");
            foreach (Ksztalt ksztalt in ksztalty)
            {
                if (ksztalt.ObliczObwod() > 10)
                {
                    Console.WriteLine($"{ksztalt.ObliczPole()}");
                }
            }
        }
    }
}