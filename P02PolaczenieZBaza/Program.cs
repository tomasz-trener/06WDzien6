using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik =
                pzb.WykonajZapytanieSQL("select imie, nazwisko, kraj from zawodnicy");

            for (int i = 0; i < wynik.Length; i++)
            {
                for (int j = 0; j < wynik[0].Length; j++)
                {
                    Console.Write(wynik[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();



        }
    }
}
