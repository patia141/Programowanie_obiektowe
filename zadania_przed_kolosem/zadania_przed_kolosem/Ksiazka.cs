using System;
using System.Collections.Generic;
using System.Text;

namespace zadania_przed_kolosem
{
    class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }

        public Ksiazka(string tytul, string autor, int rokWydania)
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokWydania;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"tytul: {Tytul}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Rok wydania: {RokWydania}");
            Console.WriteLine();
        }
    }
}
