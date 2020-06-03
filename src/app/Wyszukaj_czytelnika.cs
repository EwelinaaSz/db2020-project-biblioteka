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
        public string imie, nazwisko, id;
        public Wyszukaj_czytelnika()
        {
            InitializeComponent();

            BUT_WYBIERZ.Visible = false;
        }

        public Wyszukaj_czytelnika(Dodaj_wypozyczenie wypozyczenie)
        {
            InitializeComponent();

            BUT_DODAJ.Visible = false;
            BUT_EDYTUJ.Visible = false;
            BUT_USUN.Visible = false;
            BUT_WYPOZYCZ.Visible = false;
            BUT_WYBIERZ.Enabled = false;
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {
            Wyszukaj_czytelnika_Load(sender, e);
        }

        private void Wyszukaj_czytelnika_Load(object sender, EventArgs e)
        {
            string imie;
            string nazwisko;
            string karta;

            if (INPUT_IMIE.Text == "") imie = "'%%'";
            else imie = "'" + INPUT_IMIE.Text + "'";

            if (INPUT_NAZWISKO.Text == "") nazwisko = "'%%'";
            else nazwisko = "'" + INPUT_NAZWISKO.Text + "'";

            if (INPUT_KARTA.Text == "") karta = "czytelnik.nr_karta_biblioteczna";
            else karta = INPUT_KARTA.Text;

            string zapytanie_czytelnik = "SELECT czytelnik.nazwisko as 'Nazwisko', czytelnik.imie as 'Imie', " +
                "czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej ', czytelnik.nr_telefonu as 'Numer telefonu', " +
                "czytelnik.e_mail as 'e-mail' , adres.ulica as 'Ulica', adres.nr_domu as 'Numer domu', adres.kod_pocztowy as 'Kod pocztowy'," +
                " adres.miasto as 'Miasto', czytelnik.adres_id_fk FROM czytelnik " +
                "INNER JOIN adres ON czytelnik.adres_id_fk = adres.adres_id " +
                "WHERE czytelnik.nazwisko LIKE " + nazwisko + " AND czytelnik.imie LIKE " + imie + " AND czytelnik.nr_karta_biblioteczna = " + karta +
                " ORDER BY czytelnik.nazwisko;";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_czytelnik = new MySqlDataAdapter(zapytanie_czytelnik, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_czytelnik.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_CZYTELNICY.DataSource = lista;

            DATA_CZYTELNICY.Columns[9].Visible = false;

            INPUT_IMIE.Text = "";
            INPUT_KARTA.Text = "";
            INPUT_NAZWISKO.Text = "";
        }

        private void DATA_CZYTELNICY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUT_EDYTUJ.Enabled = true;
            BUT_USUN.Enabled = true;
            BUT_WYPOZYCZ.Enabled = true;
            BUT_WYBIERZ.Enabled = true;
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
            string zapytanie_sprawdz_wypozyczenia = "SELECT COUNT(wypozyczenie.egzemplarz_id_fk) FROM wypozyczenie INNER JOIN czytelnik " +
                "ON wypozyczenie.czytelnk_id_fk = czytelnik.nr_karta_biblioteczna WHERE czytelnik.nr_karta_biblioteczna = " + DATA_CZYTELNICY.CurrentRow.Cells[2].Value.ToString() + ";";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            polaczenie.conneciton.Open();

            MySqlDataAdapter zlap_ilosc_wypozyczen = new MySqlDataAdapter(zapytanie_sprawdz_wypozyczenia, polaczenie.conneciton);
            DataSet zlap_ilosc = new DataSet();

            zlap_ilosc_wypozyczen.Fill(zlap_ilosc);

            polaczenie.conneciton.Close();

            string ile_ma_ksiazek = zlap_ilosc.Tables[0].Rows[0]["COUNT(wypozyczenie.egzemplarz_id_fk)"].ToString();

            if (ile_ma_ksiazek == "0")
            {
                string zapytanie_usun_czytelnika = "DELETE czytelnik, adres FROM czytelnik INNER JOIN adres ON czytelnik.adres_id_fk = adres.adres_id " +
                    "WHERE czytelnik.nr_karta_biblioteczna =" + this.DATA_CZYTELNICY.CurrentRow.Cells[2].Value.ToString() + ";";

                MySqlCommand usun_czytelnika = new MySqlCommand(zapytanie_usun_czytelnika, polaczenie.conneciton);
                usun_czytelnika.CommandTimeout = 60;

                try
                {
                    polaczenie.conneciton.Open();
                    MySqlDataReader myReader = usun_czytelnika.ExecuteReader();
                    polaczenie.conneciton.Close();

                    MessageBox.Show("Usunieto czytelnika", "Powiadomienie");
                    Wyszukaj_czytelnika_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else MessageBox.Show("Czytelnik posiada nieoddane książki, nie można usunąć karty bibliotecznej", "Powiadomienie");

        }

        private void BUT_DODAJ_Click(object sender, EventArgs e)
        {
            Dodaj_czytelnika CZYT_DODAJ = new Dodaj_czytelnika();
            CZYT_DODAJ.ShowDialog();
            Wyszukaj_czytelnika_Load(sender, e);
        }

        private void BUT_WYBIERZ_Click(object sender, EventArgs e)
        {
            imie = DATA_CZYTELNICY.SelectedCells[1].Value.ToString();
            nazwisko = DATA_CZYTELNICY.SelectedCells[0].Value.ToString();
            id = DATA_CZYTELNICY.SelectedCells[2].Value.ToString();
            this.Close();
        }
    }
}
