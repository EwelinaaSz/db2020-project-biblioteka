using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace Bibioteka_Zieja_Błoniarz
{
    public partial class Wyszukaj_czytelnika : Form
    {
        public Wyszukaj_czytelnika()
        {
            InitializeComponent();
        }

        private void DATA_CZYTELNICY_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edytor_czytelnika EDYTOR = new Edytor_czytelnika();
            EDYTOR.INPUT_IMIE.Text =        this.DATA_CZYTELNICY.CurrentRow.Cells[1].Value.ToString();
            EDYTOR.INPUT_NAZWISKO.Text =    this.DATA_CZYTELNICY.CurrentRow.Cells[0].Value.ToString();
            EDYTOR.INPUT_TELEFON.Text =     this.DATA_CZYTELNICY.CurrentRow.Cells[3].Value.ToString();
            string KARTA_BIBLIOTECZNA =     this.DATA_CZYTELNICY.CurrentRow.Cells[2].Value.ToString();
            EDYTOR.INPUT_MAIL.Text =        this.DATA_CZYTELNICY.CurrentRow.Cells[4].Value.ToString();
            EDYTOR.INPUT_MIASTO.Text =      this.DATA_CZYTELNICY.CurrentRow.Cells[8].Value.ToString();
            EDYTOR.INPUT_ULICA.Text =       this.DATA_CZYTELNICY.CurrentRow.Cells[5].Value.ToString();
            EDYTOR.INPUT_DOM.Text =         this.DATA_CZYTELNICY.CurrentRow.Cells[6].Value.ToString();
            EDYTOR.INPUT_KOD.Text =         this.DATA_CZYTELNICY.CurrentRow.Cells[7].Value.ToString();

            EDYTOR.ShowDialog();
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {

        }

        private void Wyszukaj_czytelnika_Load(object sender, EventArgs e)
        {
            string zapytanie = "SELECT czytelnik.nazwisko, czytelnik.imie, czytelnik.nr_karta_biblioteczna, czytelnik.nr_telefonu, " +
                "czytelnik.e_mail , adres.ulica, adres.nr_domu, adres.kod_pocztowy, adres.miasto FROM czytelnik " +
                "INNER JOIN adres ON adres.adres_id = czytelnik.adres_id_fk GROUP BY czytelnik.nazwisko";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_tablice = new MySqlDataAdapter(zapytanie, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_tablice.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_CZYTELNICY.DataSource = lista;
        }
    }
}
