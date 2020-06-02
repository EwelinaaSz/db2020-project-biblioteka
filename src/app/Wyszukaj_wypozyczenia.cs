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
    public partial class Wyszukaj_wypozyczenia : Form
    {
        public Wyszukaj_wypozyczenia()
        {
            InitializeComponent();
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {

        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
            Dodaj_wypozyczenie wypozyczenie = new Dodaj_wypozyczenie();
            wypozyczenie.ShowDialog();
        }
    }
}
