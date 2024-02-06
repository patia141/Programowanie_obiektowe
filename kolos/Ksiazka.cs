using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        

        public Ksiazka(string tytul, string autor, int rokwydania) 
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokwydania;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Książka: '{Tytul}', autorstwa: {Autor}, rok wydania: {RokWydania}");
        }
    }
}
