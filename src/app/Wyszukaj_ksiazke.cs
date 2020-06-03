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

namespace Bibioteka_Zieja_Błoniarz
{
    public partial class Wyszukaj_ksiazke : Form
    {
        public string tytul;
        public string ISBN;
        public Wyszukaj_ksiazke()
        {
            InitializeComponent();

            BUT_WYBIERZ.Visible = false;
        }

        public Wyszukaj_ksiazke(Dodaj_wypozyczenie wypozyczenie)
        {
            InitializeComponent();

            BUT_DODAJ_KSIAZKE.Visible = false;
            BUT_DODAJ_EGZ.Visible = false;
            BUT_WYPOZYCZ.Visible = false;
            BUT_WYBIERZ.Enabled = false;
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {
            Wyszukaj_ksiazke_Load(sender, e);
        }

        private void BUT_DODAJ_Click(object sender, EventArgs e)
        {
            Dodaj_ksiazke KSIAZKA_DODAJ = new Dodaj_ksiazke();
            KSIAZKA_DODAJ.ShowDialog();
            Wyszukaj_ksiazke_Load(sender, e);
        }

        private void Wyszukaj_ksiazke_Load(object sender, EventArgs e)
        {
            string tytul;
            string nazwisko;
            string kategoria;

            if (INPUT_TYTUL.Text == "") tytul = "'%%'";
            else tytul = "'%" + INPUT_TYTUL.Text + "%'";

            if (INPUT_NAZWISKO.Text == "") nazwisko = "'%%'";
            else nazwisko = "'" + INPUT_NAZWISKO.Text + "'";

            if (INPUT_KATEGORIA.Text == "") kategoria = "'%%'";
            else kategoria = "'" + INPUT_KATEGORIA.Text + "'";

            string zapytanie_ksiazka = "SELECT ksiazka.tytul as 'Tytuł', autor.nazwisko as 'Nazwisko', autor.imie as 'Imie', ksiazka.kategoria as 'Kategoria', " +
                "ksiazka.wydawnictwo as 'Wydawnictwo', " + "ksiazka.ISBN as 'Numer ISBN', " +
                "ksiazka.data_wydania as 'Data wydania', ksiazka.liczba_stron as 'Liczba stron', COUNT(egzemplarz.egzemplarz_id) as 'Ilość dostępnych egzemplarzy'" +
                " FROM ksiazka INNER JOIN ksiazko_autor ON ksiazka.ISBN = ksiazko_autor.ksiazka_id_fk" +
                " INNER JOIN autor ON autor.autor_id = ksiazko_autor.autor_id_fk" +
                " LEFT JOIN egzemplarz ON egzemplarz.ksiazka_id_fk = ksiazka.ISBN AND egzemplarz.dostepny = true" +
                " WHERE ksiazka.tytul LIKE " + tytul + " AND autor.nazwisko LIKE " + nazwisko + " AND ksiazka.kategoria LIKE " + kategoria +
                " GROUP BY ksiazka.ISBN";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_ksiazki = new MySqlDataAdapter(zapytanie_ksiazka, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_ksiazki.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_KSIAZKI.DataSource = lista;

            INPUT_TYTUL.Text = "";
            INPUT_NAZWISKO.Text = "";

            INPUT_KATEGORIA.ResetText();
            INPUT_KATEGORIA.SelectedIndex = -1;

            BUT_WYPOZYCZ.Enabled = false;
            BUT_DODAJ_EGZ.Enabled = false;
        }

        private void BUT_DODAJ_EGZ_Click(object sender, EventArgs e)
        {
            string zapytanie_egzemplarz = "INSERT INTO `egzemplarz`(`ksiazka_id_fk`, `dostepny`) VALUES(" + DATA_KSIAZKI.SelectedCells[5].Value.ToString() +", 1);";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand dodaj_egzemplarz = new MySqlCommand(zapytanie_egzemplarz, polaczenie.conneciton);
            dodaj_egzemplarz.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_egzemplarz.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Dodano egzemplarz", "Powiadomienie");
                Wyszukaj_ksiazke_Load(sender, e);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void DATA_KSIAZKI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUT_WYBIERZ.Enabled = true;
            BUT_WYPOZYCZ.Enabled = true;
            BUT_DODAJ_EGZ.Enabled = true;
        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
            Dodaj_wypozyczenie wypozyczenie = new Dodaj_wypozyczenie(DATA_KSIAZKI.SelectedCells[0].Value.ToString(), DATA_KSIAZKI.SelectedCells[5].Value.ToString());
            wypozyczenie.ShowDialog();
        }

        private void BUT_WYBIERZ_Click(object sender, EventArgs e)
        {
            tytul = DATA_KSIAZKI.SelectedCells[0].Value.ToString();
            ISBN = DATA_KSIAZKI.SelectedCells[5].Value.ToString();
            this.Close();
        }
    }
}
