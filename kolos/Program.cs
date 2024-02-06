using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace kolos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazka1 = new Ksiazka("Koralina", "Karolina Bielecka", 1998);
            Ksiazka ksiazka2 = new Ksiazka("Chłopi", "Władysław Reymont", 1915);
            Ksiazka ksiazka3 = new Ksiazka("Ania z Zielonego Wzgórza", "Kate Smith", 2015);
            Ksiazka ksiazka4 = new Ksiazka("Latawiec", "Kate Smith", 2015);

            ListaKsiazek.Add(ksiazka1);
            ListaKsiazek.Add(ksiazka2);
            ListaKsiazek.Add(ksiazka3);
            ListaKsiazek.Add(ksiazka4);

            DodajKsiazke("Harry Potter", "J. K. Rowling", 2015);
            EdytujKsiazke("Koralina", "Aleksander Kamiński", 2005);
            //UsunKsiazke("Koralina");
            //OdczytKsiazki();

            //KsiazkiAutora("Kate Smith");
            //KsiazkiwWybranymRoku(2015);

            /*Zainicjuj listę kształtów z co najmniej 4 elementami. Wypisz pole dla kształtów posiadających
            obwód większy od 10*/

            List<Ksztalt> ksztalty = new List<Ksztalt>();
            ksztalty.Add(new Prostokat { X = 0, Y = 0, A=5, B=6 });
            ksztalty.Add(new Prostokat { X = 0, Y = 0, A = 2, B = 2 });
            ksztalty.Add(new Trojkat { X = 0, Y = 0, A = 3, B = 5, C=3 });
            ksztalty.Add(new Kolo { X = 0, Y = 0, R=4});

            Console.WriteLine("Pola kształtów, których obwód jest większy od 10:");
            foreach (var ksztalt in ksztalty)
            {
                if (ksztalt.Obwod() > 10)
                {
                    Console.WriteLine($"Pole: {ksztalt.Pole()}");
                }
            }

        }

        static List<Ksiazka> ListaKsiazek = new List<Ksiazka>();

        static void DodajKsiazke(string tytul, string autor, int rokWydania)
        {
            ListaKsiazek.Add(new Ksiazka(tytul, autor, rokWydania));
        }

        static void OdczytKsiazki()
        {
            Console.WriteLine("Lista książek:");
            foreach (var Ksiazka in ListaKsiazek)
            {
                Ksiazka.Wyswietl();
            }
        }

        static void EdytujKsiazke(string tytul, string nowyAutor, int nowyRokWydania)
        {
            var Ksiazka = ListaKsiazek.Find(k => k.Tytul == tytul);
            if(Ksiazka != null)
            {
                Ksiazka.Autor = nowyAutor;
                Ksiazka.RokWydania = nowyRokWydania;
            }
            else
            {
                Console.WriteLine("Książka o podanym tytule nie została znaleziona.");
            }
        }

        static void UsunKsiazke(string tytul)
        {
            var Ksiazka = ListaKsiazek.Find(k => k.Tytul == tytul);
            if(Ksiazka != null)
            {
                ListaKsiazek.Remove(Ksiazka);
                Console.WriteLine("Ksiązka została usunięta.");
            }
            else
            {
                Console.WriteLine("Książka o podanym tytule nie została znaleziona.");
            }
        }

        static void KsiazkiAutora(string autor)
        {
            var ksiazkiAutora = ListaKsiazek.Where(k => k.Autor == autor).ToList();
            if(ksiazkiAutora.Any())
            {
                Console.WriteLine($"Lista książek autora {autor}:");
                foreach(var Ksiazka in ksiazkiAutora)
                {
                    Ksiazka.Wyswietl();
                }
            }
            else
            {
                Console.WriteLine("Podany autor nie został znaleziony");
            }
        }

        static void KsiazkiwWybranymRoku(int rokWydania)
        {
            var ksiazkiwRoku = ListaKsiazek.Where(k => k.RokWydania == rokWydania).ToList();
            if(ksiazkiwRoku.Any())
            {
                Console.WriteLine($"Ksiażki wydane w {rokWydania} roku:");
                foreach(var Ksiazka in ksiazkiwRoku)
                {
                    Ksiazka.Wyswietl();
                }
            }
            else
            {
                Console.WriteLine("Brak ksiązek wydanych w podanym roku.");
            }
        }
    }
}
