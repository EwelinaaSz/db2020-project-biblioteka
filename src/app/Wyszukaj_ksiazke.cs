﻿using System;
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
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {

        }

        private void BUT_DODAJ_Click(object sender, EventArgs e)
        {
            Dodaj_ksiazke KSIAZKA_DODAJ = new Dodaj_ksiazke();
            KSIAZKA_DODAJ.ShowDialog();
        }
    }
}