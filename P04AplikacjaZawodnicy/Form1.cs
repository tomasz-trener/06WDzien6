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
    }
}
