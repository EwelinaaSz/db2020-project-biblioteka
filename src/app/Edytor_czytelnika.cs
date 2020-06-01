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
    public partial class Edytor_czytelnika : Form
    {
        public Edytor_czytelnika()
        {
            InitializeComponent();
        }

        private void BUT_EDYTUJ_Click(object sender, EventArgs e)
        {

        }

        private void BUT_USUN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien?", "Potwierdzenie", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {

            }
        }
    }
}
