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

        private void Wy_Wyszukaj_Click(object sender, EventArgs e)
        {
            Wyszukaj_wypozyczenia WY_WYSZUKAJ = new Wyszukaj_wypozyczenia();
            WY_WYSZUKAJ.ShowDialog();
        }
    }
}
