using System;
using System.Collections.Generic;
using System.Linq;

namespace zadania_przed_kolosem
{
    class Program
    {
        static List<Ksiazka> listaKsiazek = new List<Ksiazka>();

        static void DodajKsiążkę(string tytul, string autor, int rokWydania)
        {
            listaKsiazek.Add(new Ksiazka(tytul, autor, rokWydania));
        }

        static void OdczytajKsiążki()
        {
            Console.WriteLine("Lista książek:");
            foreach (var Ksiazka in listaKsiazek)
            {
                Ksiazka.Wyswietl();
            }
        }

        static void EdytujKsiążkę(string tytul, string nowyAutor, int nowyRokWydania)
        {
            var Ksiazka = listaKsiazek.Find(k => k.Tytul == tytul);
            if (Ksiazka != null)
            {
                Ksiazka.Autor = nowyAutor;
                Ksiazka.RokWydania = nowyRokWydania;
                Console.WriteLine($"Ksiazka '{tytul}' została zaktualizowana.");
            }
            else
            {
                Console.WriteLine($"Ksiazka o tytule '{tytul}' nie została znaleziona.");
            }
        }

        static void UsuńKsiążkę(string tytul)
        {
            var Ksiazka = listaKsiazek.Find(k => k.Tytul == tytul);
            if (Ksiazka != null)
            {
                listaKsiazek.Remove(Ksiazka);
                Console.WriteLine($"Ksiazka '{tytul}' została usunięta.");
            }
            else
            {
                Console.WriteLine($"Ksiazka o tytule '{tytul}' nie została znaleziona.");
            }
        }

        static void WypiszKsiazkiAutora(string autor)
        {
            var ksiazkiAutora = listaKsiazek.Where(k => k.Autor == autor).ToList();
            if (ksiazkiAutora.Any())
            {
                Console.WriteLine($"Książki autora '{autor}':");
                foreach (var Ksiazka in ksiazkiAutora)
                {
                    Ksiazka.Wyswietl();
                }
            }
            else
            {
                Console.WriteLine($"Brak książek autora '{autor}'.");
            }
        }

        static void WypiszKsiążkiWydaneWWybranymRoku(int rok)
        {
            var książkiWWybranymRoku = listaKsiazek.Where(k => k.RokWydania == rok).ToList();
            if (książkiWWybranymRoku.Any())
            {
                Console.WriteLine($"Książki wydane w roku {rok}:");
                foreach (var Ksiazka in książkiWWybranymRoku)
                {
                    Ksiazka.Wyswietl();
                }
            }
            else
            {
                Console.WriteLine($"Brak książek wydanych w roku {rok}.");
            }
        }
        static void Main(string[] args)
        {
            Ksiazka ksiazka1 = new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", 1954);
            Ksiazka ksiazka2 = new Ksiazka("Harry Potter", "J.K. Rowling", 1997);
            Ksiazka ksiazka3 = new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866);

            ksiazka1.Wyswietl();
            ksiazka2.Wyswietl();
            ksiazka3.Wyswietl();

            //lista

            OdczytajKsiążki();

            EdytujKsiążkę("Władca Pierścieni", "Nowy Autor", 2000);
            UsuńKsiążkę("Harry Potter");

            OdczytajKsiążki();

            WypiszKsiazkiAutora("J.R.R. Tolkien");
            WypiszKsiążkiWydaneWWybranymRoku(1866);

            //zad 3
            List<Ksztalt> listaKsztaltów = new List<Ksztalt>
        {
            new Prostokąt { Długość = 5, Szerokość = 3 },
            new Trójkąt { BokA = 4, BokB = 5, BokC = 6 },
            new Koło { Promień = 2 },
            new Prostokąt { Długość = 8, Szerokość = 2 }
        };

            foreach (var Ksztalt in listaKsztaltów)
            {
                if (Ksztalt.Obwód > 10)
                {
                    Console.WriteLine($"Pole Ksztaltu: {Ksztalt.Pole}");
                }
            }
        }
    }
}
