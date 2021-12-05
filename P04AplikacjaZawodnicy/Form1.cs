using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mz.Wczytaj();

            lbDane.DataSource = mz.Zawodnicy;
            lbDane.DisplayMember = "CalyRekord";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik(txtImie.Text, txtNazwisko.Text);
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpData.Value;
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.Dodaj(z);
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
    }
}
