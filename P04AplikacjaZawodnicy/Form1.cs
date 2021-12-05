using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.ListBox;

namespace P04AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Odswiez()
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            
            CheckedItemCollection soc = chbListKolumny.CheckedItems;
            mz.Wczytaj(soc);

            lbDane.DataSource = mz.Zawodnicy;
            lbDane.DisplayMember = "WybraneKolumny";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private Zawodnik ZczytajZawodnika()
        {
            Zawodnik z = new Zawodnik(txtImie.Text, txtNazwisko.Text);
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpData.Value;
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);
            return z;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {    
            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.Dodaj(ZczytajZawodnika());
            Odswiez();
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;
            txtWzrost.Text =Convert.ToString(zaznaczony.Wzrost);
            txtWaga.Text = Convert.ToString(zaznaczony.Waga);
            dtpData.Value = zaznaczony.DataUrodzenia;
        }

        private void btnEdytuj_Click(object sender, EventArgs e) 
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik z = ZczytajZawodnika();
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            z.Id_zawodnika = zaznaczony.Id_zawodnika;
            mz.Edytuj(z);
            Odswiez();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.Usun(zaznaczony.Id_zawodnika);
            Odswiez();
        }
    }
}
