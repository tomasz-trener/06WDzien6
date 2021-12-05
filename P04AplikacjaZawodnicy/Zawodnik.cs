using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int? Id_trenera; //dodanie ? powoduje, że typ jest nullable 
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string ImieNazwisko { get { return Imie + " " + Nazwisko; } }

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam {Imie} {Nazwisko} i pochodze z {Kraj}";
        }

    }
}
