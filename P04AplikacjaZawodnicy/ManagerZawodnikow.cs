using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy
{
    class ManagerZawodnikow
    {

        public Zawodnik[] Zawodnicy;

        public void Wczytaj()
        {
            string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik= pzb.WykonajZapytanieSQL("select * from zawodnicy");

            Zawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik((string)wynik[i][2], (string)wynik[i][3]);
                z.Id_zawodnika = (int)wynik[i][0];
                z.Id_trenera = (int)wynik[i][1];
                z.Kraj = (string)wynik[i][4];
                z.DataUrodzenia = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];
                Zawodnicy[i] = z;
            }
        }
    }
}
