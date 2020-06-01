using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibioteka_Zieja_Błoniarz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Cz_Dodaj_Click(object sender, EventArgs e)
        {
            Dodaj_czytelnika CZYT_DODAJ = new Dodaj_czytelnika();
            CZYT_DODAJ.ShowDialog();
        }

        private void Ks_Dodaj_Click(object sender, EventArgs e)
        {
            Dodaj_ksiazke KSIAZKA_DODAJ = new Dodaj_ksiazke();
            KSIAZKA_DODAJ.ShowDialog();
        }

        private void Wy_Dodaj_Click(object sender, EventArgs e)
        {
            Dodaj_wypozyczenie WYP_DODAJ = new Dodaj_wypozyczenie();
            WYP_DODAJ.ShowDialog();
        }

        private void Cz_Wyszukaj_Click(object sender, EventArgs e)
        {
            Wyszukaj_czytelnika CZYT_WYSZUKAJ = new Wyszukaj_czytelnika();
            CZYT_WYSZUKAJ.ShowDialog();
        }

        private void Ks_Wyszukaj_Click(object sender, EventArgs e)
        {
            Wyszukaj_ksiazke KSIAZKA_WYSZUKAJ = new Wyszukaj_ksiazke();
            KSIAZKA_WYSZUKAJ.ShowDialog();
        }
    }
}
