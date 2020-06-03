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
    public partial class Dodaj_wypozyczenie : Form
    {
        string czytelnik_id;
        string tytul_id;

        public Dodaj_wypozyczenie()
        {
            InitializeComponent();
        }

        public Dodaj_wypozyczenie(string imie, string nazwisko, string karta)
        {
            InitializeComponent();

            IMIE.Text = imie;
            NAZWISKO.Text = nazwisko;
            czytelnik_id = karta;
        }

        public Dodaj_wypozyczenie(string tytul, string ISBN)
        {
            InitializeComponent();

            TYTUL.Text = tytul;
            tytul_id = ISBN;
        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
            string zapytanie_id_egzemplarz = "SELECT egzemplarz.egzemplarz_id FROM egzemplarz INNER JOIN ksiazka " +
                "ON egzemplarz.ksiazka_id_fk = ksiazka.ISBN WHERE egzemplarz.dostepny = true AND ksiazka.ISBN = " +
                tytul_id + " ORDER BY egzemplarz.egzemplarz_id";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            polaczenie.conneciton.Open();

            MySqlDataAdapter zlap_id_egzemplarz = new MySqlDataAdapter(zapytanie_id_egzemplarz, polaczenie.conneciton);
            
            DataSet zlap_egzemplarz = new DataSet();

            int czy_sa_wolne = zlap_id_egzemplarz.Fill(zlap_egzemplarz);

            polaczenie.conneciton.Close();

            if (czy_sa_wolne > 0)
            {
                string egzemplarz_ID = zlap_egzemplarz.Tables[0].Rows[0]["egzemplarz_id"].ToString();

                DateTime zlap_date = DateTime.Now;
                DateTime oddaj_data;
                oddaj_data = zlap_date.AddMonths(1);

                string miesiac_zwrotu, dzien_zwrotu, miesiac_wyporzyczenia, dzien_wyporzyczenia;

                if (oddaj_data.Month < 10) miesiac_zwrotu = "0" + oddaj_data.Month.ToString();
                else miesiac_zwrotu = oddaj_data.Month.ToString();
                if (oddaj_data.Day < 10) dzien_zwrotu = "0" + oddaj_data.Day.ToString();
                else dzien_zwrotu = oddaj_data.Day.ToString();

                if (zlap_date.Month < 10) miesiac_wyporzyczenia = "0" + zlap_date.Month.ToString();
                else miesiac_wyporzyczenia = zlap_date.Month.ToString();
                if (zlap_date.Day < 10) dzien_wyporzyczenia = "0" + zlap_date.Day.ToString();
                else dzien_wyporzyczenia = zlap_date.Day.ToString();

                string zapytanie_wyporzyczenie = "INSERT INTO `wypozyczenie`(`data_wypozyczenia`, `data_zwrotu`, `czytelnk_id_fk`, `egzemplarz_id_fk`) " +
                    " VALUES(" + zlap_date.Year.ToString() + miesiac_wyporzyczenia + dzien_wyporzyczenia + ","
                    + oddaj_data.Year.ToString() + miesiac_zwrotu + dzien_zwrotu + "," + czytelnik_id + "," + egzemplarz_ID + ");" +
                    " UPDATE `egzemplarz` SET `dostepny` = false WHERE egzemplarz.egzemplarz_id = " + egzemplarz_ID + ";";

                MySqlCommand dodaj_wypozyczenie = new MySqlCommand(zapytanie_wyporzyczenie, polaczenie.conneciton);
                dodaj_wypozyczenie.CommandTimeout = 60;

                try
                {
                    polaczenie.conneciton.Open();
                    MySqlDataReader myReader = dodaj_wypozyczenie.ExecuteReader();
                    polaczenie.conneciton.Close();

                    MessageBox.Show("Dodano wypożyczenie", "Powiadomienie");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else MessageBox.Show("Przepraszamy nie posiadamy już egzemplarzy danej książki", "Przepraszamy");

        }

        private void BUT_WY_CZYT_Click(object sender, EventArgs e)
        {
            Wyszukaj_czytelnika czytelnik = new Wyszukaj_czytelnika(this);
            czytelnik.ShowDialog();

            IMIE.Text = czytelnik.imie;
            NAZWISKO.Text = czytelnik.nazwisko;
            czytelnik_id = czytelnik.id;
        }

        private void BUT_WY_KS_Click(object sender, EventArgs e)
        {
            Wyszukaj_ksiazke ksiazka = new Wyszukaj_ksiazke(this);
            ksiazka.ShowDialog();

            TYTUL.Text = ksiazka.tytul;
            tytul_id = ksiazka.ISBN;
        }

    }
}
