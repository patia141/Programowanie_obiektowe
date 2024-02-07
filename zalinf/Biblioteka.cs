using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public class Biblioteka
    {

        public List<Ksiazka> biblioteka = new List<Ksiazka>();

        public void DodajKsiazke(Ksiazka ksiazka)
        {
            biblioteka.Add(ksiazka);
        }

        public void WyswietlWszystkieKsiazki()
        {
            foreach (var item in biblioteka)
            {
                item.WyswietlInfo();
            }
        }

        // Wypisywanie ksiazek wydanych po podanym roku
        public void WyswietlKsiazkiPoRoku(int rok)
        {
            Console.WriteLine($"Książki wydane w {rok}: ");
            foreach (var ksiazka in biblioteka)
            {
                if (ksiazka.RokWydania == rok)
                {
                    ksiazka.WyswietlInfo();
                }
            }
        }

        // Wypisywanie ksiazek wydanych przez podanego autora
        public void WyswietlKsiazkiAutora(string autor)
        {
            Console.WriteLine($"Książki {autor}: ");
            foreach (var ksiazka in biblioteka)
            {
                if (ksiazka.Autor == autor)
                {
                    ksiazka.WyswietlInfo();
                }
            }
        }

        // Edycja ksiazki
        public void EdytujKsiazke(string Tytul, string nowyTytul, string nowyAutor, int nowyRokWydania)
        {
            foreach (var ksiazka in biblioteka)
            {
                if (ksiazka.Tytul == Tytul)
                {
                    ksiazka.Tytul = nowyTytul;
                    ksiazka.Autor = nowyAutor;
                    ksiazka.RokWydania = nowyRokWydania;
                }
            }
        }

        // Usuwanie ksiazki
        public void UsunKsiazke(string Tytul)
        {
            foreach (var ksiazka in biblioteka)
            {
                if (ksiazka.Tytul == Tytul)
                {
                    biblioteka.Remove(ksiazka);
                }
            }
        }
    }
}
