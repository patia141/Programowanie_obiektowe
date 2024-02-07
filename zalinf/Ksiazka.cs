using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public int RokWydania;
        public Ksiazka(string Tytul, string Autor, int RokWydania)
        {
            this.Tytul = Tytul;
            this.Autor = Autor;
            this.RokWydania = RokWydania;
        }

        public void WyswietlInfo()
        {
            Console.WriteLine($"Tytul: {Tytul}, Autor: {Autor}, Rok wydania: {RokWydania}");
        }
    }
}
