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
        public Dodaj_wypozyczenie()
        {
            InitializeComponent();
        }

        public Dodaj_wypozyczenie(string imie, string nazwisko, string karta)
        {
            InitializeComponent();

            INPUT_CZYTELNIK.Items.Add(imie + " " + nazwisko + "                                                                        #" + karta);
            INPUT_CZYTELNIK.SelectedIndex = 0;
            INPUT_CZYTELNIK.Enabled = false;

            INPUT_KSIAZKA.Items.Clear();

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            string zapytanie_combo_ksiazka = "SELECT ksiazka.tytul, ksiazka.ISBN FROM ksiazka;";

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_dane_ksiazka = new MySqlDataAdapter(zapytanie_combo_ksiazka, polaczenie.conneciton);
            DataTable combobox_ksiazka = new DataTable();

            pobierz_dane_ksiazka.Fill(combobox_ksiazka);

            foreach (DataRow row in combobox_ksiazka.Rows)
            {
                string zapis = row["tytul"].ToString() + "                                                                              #" + row["ISBN"].ToString();
                INPUT_KSIAZKA.Items.Add(zapis);
            }
            polaczenie.conneciton.Close();
        }

        public Dodaj_wypozyczenie(string tytul, string ISBN)
        {
            InitializeComponent();

            INPUT_KSIAZKA.Items.Add(tytul + "                                                                        #" + ISBN);
            INPUT_KSIAZKA.Enabled = false;
        }

        private void BUT_WYPOZYCZ_Click(object sender, EventArgs e)
        {
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

            string zlap_id_czytelnik = INPUT_CZYTELNIK.Text.Substring(INPUT_CZYTELNIK.Text.IndexOf('#') + 1);
            string zlap_id_egzemplarz = INPUT_KSIAZKA.Text.Substring(INPUT_KSIAZKA.Text.IndexOf('#') + 1);

            string zapytanie_wyporzyczenie = "INSERT INTO `wypozyczenie`(`data_wypozyczenia`, `data_zwrotu`, `czytelnk_id_fk`, `egzemplarz_id_fk`) " +
                "VALUES(" + zlap_date.Year.ToString() + miesiac_wyporzyczenia + dzien_wyporzyczenia + "," 
                + oddaj_data.Year.ToString() + miesiac_zwrotu + dzien_zwrotu + "," + zlap_id_czytelnik + "," + zlap_id_egzemplarz + ");";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
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
            return;

        }
    }
}
