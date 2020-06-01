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
    public partial class Wyszukaj_ksiazke : Form
    {
        public Wyszukaj_ksiazke()
        {
            InitializeComponent();

            SQL_METHODS wczytaj = new SQL_METHODS();

            DataTable lista = new DataTable();

            lista = wczytaj.List_All_Books();

            DATA_KSIAZKI.DataSource = lista;
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {

        }
    }
}
