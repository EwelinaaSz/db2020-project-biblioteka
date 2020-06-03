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
    public partial class Wyszukaj_wypozyczenia : Form
    {
        bool przetrzymania_zaznaczone;
        public Wyszukaj_wypozyczenia()
        {
            InitializeComponent();
        }

        private void BUT_SZUKAJ_Click(object sender, EventArgs e)
        {
            if(przetrzymania_zaznaczone)
            {
                pokaz_tylko_przetrzymania();
            }
            else
            {
                Wyszukaj_wypozyczenia_Load(sender, e);
            }
        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
            Dodaj_wypozyczenie wypozyczenie = new Dodaj_wypozyczenie();
            wypozyczenie.ShowDialog();
        }

        private void pokaz_tylko_przetrzymania()
        {
            string tytul;
            string nazwisko;
            string karta;

            if (INPUT_TYTUL.Text == "") tytul = "'%%'";
            else tytul = "'%" + INPUT_TYTUL.Text + "%'";

            if (INPUT_NAZWISKO.Text == "") nazwisko = "'%%'";
            else nazwisko = "'" + INPUT_NAZWISKO.Text + "'";

            if (INPUT_KARTA.Text == "") karta = "czytelnik.nr_karta_biblioteczna";
            else karta = INPUT_KARTA.Text;

            string zapytanie_przetrzymania = "SELECT czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej', " +
                "czytelnik.imie as 'Imie', czytelnik.nazwisko as 'Nazwisko', ksiazka.tytul as 'Tytuł', egzemplarz.egzemplarz_id, " +
                "wypozyczenie.data_wypozyczenia as 'Data wypożyczenia', wypozyczenie.data_zwrotu as 'Data zwrotu'" +
                " FROM wypozyczenie INNER JOIN czytelnik ON czytelnik.nr_karta_biblioteczna = wypozyczenie.czytelnk_id_fk" +
                " INNER JOIN egzemplarz ON egzemplarz.egzemplarz_id = wypozyczenie.egzemplarz_id_fk" +
                " INNER JOIN ksiazka ON ksiazka.ISBN = egzemplarz.ksiazka_id_fk " +
                " WHERE CURDATE() > wypozyczenie.data_zwrotu AND czytelnik.nazwisko LIKE " + nazwisko + " AND ksiazka.tytul LIKE " + tytul + " AND czytelnik.nr_karta_biblioteczna = " + karta + ";";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_przetrzymania = new MySqlDataAdapter(zapytanie_przetrzymania, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_przetrzymania.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_WYPOZYCZENIA.DataSource = lista;

            DATA_WYPOZYCZENIA.Columns[4].Visible = false;

            INPUT_TYTUL.Text = "";
            INPUT_KARTA.Text = "";
            INPUT_NAZWISKO.Text = "";

            BUT_PRZETRZYMANIA.Visible = false;
            BUT_WSZYSTKIE.Visible = true;
            przetrzymania_zaznaczone = true;
        }

        private void Wyszukaj_wypozyczenia_Load(object sender, EventArgs e)
        {
            string tytul ;
            string nazwisko;
            string karta;

            if (INPUT_TYTUL.Text == "") tytul = "'%%'";
            else tytul = "'%" + INPUT_TYTUL.Text + "%'";

            if (INPUT_NAZWISKO.Text == "") nazwisko = "'%%'";
            else nazwisko = "'" + INPUT_NAZWISKO.Text + "'";

            if (INPUT_KARTA.Text == "") karta = "czytelnik.nr_karta_biblioteczna";
            else karta = INPUT_KARTA.Text;

            string zapytanie_wypozyczenia = "SELECT czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej', " +
                "czytelnik.imie as 'Imie', czytelnik.nazwisko as 'Nazwisko', ksiazka.tytul as 'Tytuł', egzemplarz.egzemplarz_id, " +
                "wypozyczenie.data_wypozyczenia as 'Data wypożyczenia', wypozyczenie.data_zwrotu as 'Data zwrotu'" +
                " FROM wypozyczenie INNER JOIN czytelnik ON czytelnik.nr_karta_biblioteczna = wypozyczenie.czytelnk_id_fk" +
                " INNER JOIN egzemplarz ON egzemplarz.egzemplarz_id = wypozyczenie.egzemplarz_id_fk" +
                " INNER JOIN ksiazka ON ksiazka.ISBN = egzemplarz.ksiazka_id_fk " +
                " WHERE czytelnik.nazwisko LIKE " + nazwisko + " AND ksiazka.tytul LIKE " + tytul + " AND czytelnik.nr_karta_biblioteczna = " + karta + ";";

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_wypozyczenia = new MySqlDataAdapter(zapytanie_wypozyczenia, polaczenie.conneciton);

            DataTable lista = new DataTable();

            pobierz_wypozyczenia.Fill(lista);

            polaczenie.conneciton.Close();

            DATA_WYPOZYCZENIA.DataSource = lista;

            DATA_WYPOZYCZENIA.Columns[4].Visible = false;

            INPUT_TYTUL.Text = "";
            INPUT_KARTA.Text = "";
            INPUT_NAZWISKO.Text = "";

            BUT_WSZYSTKIE.Visible = false;
            BUT_PRZETRZYMANIA.Visible = true;
            przetrzymania_zaznaczone = false;
        }

        private void BUT_PRZETRZYMANIA_Click(object sender, EventArgs e)
        {
            pokaz_tylko_przetrzymania();
        }

        private void BUT_WSZYSTKIE_Click(object sender, EventArgs e)
        {
            Wyszukaj_wypozyczenia_Load(sender, e);
        }
    }
}
