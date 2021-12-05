using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy
{
    class ManagerZawodnikow
    {
        string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";

        public Zawodnik[] Zawodnicy;

        public void Wczytaj()
        {
          
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik= pzb.WykonajZapytanieSQL("select * from zawodnicy");

            Zawodnicy = new Zawodnik[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Zawodnik z = new Zawodnik((string)wynik[i][2], (string)wynik[i][3]);
                z.Id_zawodnika = (int)wynik[i][0];


                if(!(wynik[i][1] is DBNull))
                    z.Id_trenera = (int)wynik[i][1];

                //try
                //{
                //    z.Id_trenera = (int)wynik[i][1];
                //}
                //catch (Exception)
                //{

                //}
                // z.Id_trenera = (int?)wynik[i][1]; (NULL w bazie danych<> NULL w C#)

                z.Kraj = (string)wynik[i][4];
                z.DataUrodzenia = (DateTime)wynik[i][5];
                z.Wzrost = (int)wynik[i][6];
                z.Waga = (int)wynik[i][7];
                Zawodnicy[i] = z;
            }
        }

        public void Dodaj(Zawodnik z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            string sql = 
                string.Format("insert into zawodnicy values(null, '{0}', '{1}', '{2}', '{3}', {4}, {5});",
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia,z.Wzrost,z.Waga);
         
            pzb.WykonajZapytanieSQL(sql);
        }

        public void Edytuj(Zawodnik z)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            string sql = string.Format(
                "update zawodnicy set " +
                   " imie = '{0}', " +
                   " nazwisko = '{1}', " +
                   " kraj = '{2}', " +
                   " data_ur = '{3}', " +
                   " wzrost = {4}, " +
                   " waga = {5}" +
                   " where id_zawodnika = {6}",
                z.Imie,z.Nazwisko,z.Kraj,z.DataUrodzenia,z.Wzrost,z.Waga,z.Id_zawodnika);
          
            pzb.WykonajZapytanieSQL(sql);
        }

        public void Usun(int id)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            string sql = string.Format("delete zawodnicy where id_zawodnika={0}", id);

            pzb.WykonajZapytanieSQL(sql);

        }
    }
}
