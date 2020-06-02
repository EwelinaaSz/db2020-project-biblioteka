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

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {
            BUT_EDYTUJ.Enabled = false;
            BUT_USUN.Enabled = false;
            BUT_WYPOZYCZ.Enabled = false;

            string imie;
            string nazwisko;
            string karta;

            if (INPUT_IMIE.Text == "") imie = "\'%%\'";
            else imie = "'" + INPUT_IMIE.Text + "'";

            if (INPUT_NAZWISKO.Text == "") nazwisko = "\'%%\'";
            else nazwisko = "'" + INPUT_NAZWISKO.Text + "'";

            if (INPUT_KARTA.Text == "") karta = "czytelnik.nr_karta_biblioteczna";
            else karta = INPUT_KARTA.Text;

            string zapytanie_szukaj_czytelnik = "SELECT czytelnik.nazwisko, czytelnik.imie, czytelnik.nr_karta_biblioteczna, czytelnik.nr_telefonu, " +
                "czytelnik.e_mail , adres.ulica, adres.nr_domu, adres.kod_pocztowy, adres.miasto, czytelnik.adres_id_fk FROM czytelnik " +
                "INNER JOIN adres ON czytelnik.adres_id_fk = adres.adres_id " +
                "WHERE czytelnik.nazwisko LIKE " + nazwisko + " AND czytelnik.imie LIKE " + imie + " AND czytelnik.nr_karta_biblioteczna = " + karta +
                " ORDER BY czytelnik.nazwisko;";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_tablice = new MySqlDataAdapter(zapytanie_szukaj_czytelnik, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_tablice.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_CZYTELNICY.DataSource = lista;

            DATA_CZYTELNICY.Columns[9].Visible = false;
        }

        private void Wyszukaj_czytelnika_Load(object sender, EventArgs e)
        {
            string zapytanie = "SELECT czytelnik.nazwisko, czytelnik.imie, czytelnik.nr_karta_biblioteczna, czytelnik.nr_telefonu, " +
                "czytelnik.e_mail , adres.ulica, adres.nr_domu, adres.kod_pocztowy, adres.miasto, czytelnik.adres_id_fk FROM czytelnik " +
                "INNER JOIN adres ON adres.adres_id = czytelnik.adres_id_fk ORDER BY czytelnik.nazwisko";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_tablice = new MySqlDataAdapter(zapytanie, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_tablice.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_CZYTELNICY.DataSource = lista;

            DATA_CZYTELNICY.Columns[9].Visible = false;
        }

        private void DATA_CZYTELNICY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUT_EDYTUJ.Enabled = true;
            BUT_USUN.Enabled = true;
            BUT_WYPOZYCZ.Enabled = true;
        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
            Dodaj_wypozyczenie wypozyczenie = new Dodaj_wypozyczenie(this.DATA_CZYTELNICY.CurrentRow.Cells[1].Value.ToString(), this.DATA_CZYTELNICY.CurrentRow.Cells[0].Value.ToString(), this.DATA_CZYTELNICY.CurrentRow.Cells[2].Value.ToString());
            wypozyczenie.ShowDialog();
        }

        private void BUT_EDYTUJ_Click(object sender, EventArgs e)
        {
            string KARTA_BIBLIOTECZNA = this.DATA_CZYTELNICY.CurrentRow.Cells[2].Value.ToString();
            string ADRES_ID = this.DATA_CZYTELNICY.CurrentRow.Cells[9].Value.ToString();

            Edytor_czytelnika EDYTOR = new Edytor_czytelnika(KARTA_BIBLIOTECZNA, ADRES_ID);
            EDYTOR.INPUT_IMIE.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[1].Value.ToString();
            EDYTOR.INPUT_NAZWISKO.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[0].Value.ToString();
            EDYTOR.INPUT_TELEFON.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[3].Value.ToString();
            EDYTOR.INPUT_MAIL.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[4].Value.ToString();
            EDYTOR.INPUT_MIASTO.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[8].Value.ToString();
            EDYTOR.INPUT_ULICA.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[5].Value.ToString();
            EDYTOR.INPUT_DOM.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[6].Value.ToString();
            EDYTOR.INPUT_KOD.Text = this.DATA_CZYTELNICY.CurrentRow.Cells[7].Value.ToString();

            EDYTOR.ShowDialog();
            Wyszukaj_czytelnika_Load(sender, e);
        }

        private void BUT_USUN_Click(object sender, EventArgs e)
        {

        }

        private void BUT_DODAJ_Click(object sender, EventArgs e)
        {
            Dodaj_czytelnika CZYT_DODAJ = new Dodaj_czytelnika();
            CZYT_DODAJ.ShowDialog();
            Wyszukaj_czytelnika_Load(sender, e);
        }
    }
}
