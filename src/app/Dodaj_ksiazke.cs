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
    public partial class Dodaj_ksiazke : Form
    {
        public Dodaj_ksiazke()
        {
            InitializeComponent();
        }

        private void ZYJE_CheckedChanged(object sender, EventArgs e)
        {
            if (ZYJE.Checked)
            {
                INPUT_DATA_S.Enabled = false;
            }
            else
            {
                INPUT_DATA_S.Enabled = true;
            }
        }

        private void BUT_KSIAZKA_Click(object sender, EventArgs e)
        {
            string miesiac, dzien;
            if (INPUT_DATA_WY.Value.Month < 10) miesiac = "0" + INPUT_DATA_WY.Value.Month.ToString();
            else miesiac = INPUT_DATA_WY.Value.Month.ToString();
            if (INPUT_DATA_WY.Value.Day < 10) dzien = "0" + INPUT_DATA_WY.Value.Day.ToString();
            else dzien = INPUT_DATA_WY.Value.Day.ToString();

            string zapytanie_ksiazka = "INSERT INTO `ksiazka`(`ISBN`, `tytul`, `kategoria`, `wydawnictwo`, `data_wydania`, `liczba_stron`) " +
                "VALUES (" + INPUT_ISBN.Text + ",'" + INPUT_TYTUL.Text + "','" + INPUT_KATEGORIA.Text + "','" + INPUT_WYDAWNICTWO.Text + "',"
                + INPUT_DATA_WY.Value.Year.ToString() + miesiac + dzien + ","
                + INPUT_STRONY.Text + ");";


            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand dodaj_ksiazke = new MySqlCommand(zapytanie_ksiazka, polaczenie.conneciton);
            dodaj_ksiazke.CommandTimeout = 60;

            string zlap_id_autor = INPUT_AUTOR.Text.Substring(INPUT_AUTOR.Text.IndexOf('#') + 1);
            
            string zapytanie_ksiazko_autor = "INSERT INTO `ksiazko_autor`(`autor_id_fk`, `ksiazka_id_fk`) VALUES (" + zlap_id_autor + "," + INPUT_ISBN.Text + ");";

            MySqlCommand dodaj_ksiazko_autora = new MySqlCommand(zapytanie_ksiazko_autor, polaczenie.conneciton);
            dodaj_ksiazko_autora.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_ksiazke.ExecuteReader();
                polaczenie.conneciton.Close();

                polaczenie.conneciton.Open();
                MySqlDataReader myReader_1 = dodaj_ksiazko_autora.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Dodano ksiazke", "Powiadomienie");
                Dodaj_ksiazke_Load(this, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            } 

            string zapytanie_egzemplarz = "INSERT INTO `egzemplarz`(`ksiazka_id_fk`, `dostepny`) VALUES(" + INPUT_ISBN.Text + ", 1);";

            MySqlCommand dodaj_egzemplarz = new MySqlCommand(zapytanie_egzemplarz, polaczenie.conneciton);
            dodaj_egzemplarz.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_egzemplarz.ExecuteReader();
                polaczenie.conneciton.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }

        private void BUT_AUTOR_Click(object sender, EventArgs e)
        {
            string miesiac_u, dzien_u, dzien, miesiac;
            if (INPUT_DATA_WY.Value.Month < 10) miesiac_u = "0" + INPUT_DATA_U.Value.Month.ToString();
            else miesiac_u = INPUT_DATA_U.Value.Month.ToString();
            if (INPUT_DATA_WY.Value.Day < 10) dzien_u = "0" + INPUT_DATA_U.Value.Day.ToString();
            else dzien_u = INPUT_DATA_U.Value.Day.ToString();

            if (INPUT_DATA_WY.Value.Month < 10) miesiac = "0" + INPUT_DATA_S.Value.Month.ToString();
            else miesiac = INPUT_DATA_S.Value.Month.ToString();
            if (INPUT_DATA_WY.Value.Day < 10) dzien = "0" + INPUT_DATA_S.Value.Day.ToString();
            else dzien = INPUT_DATA_S.Value.Day.ToString();

            string zapytanie_autor;
            if (ZYJE.Checked == false)
            {
                zapytanie_autor = "INSERT INTO `autor`(`imie`, `nazwisko`, `data_urodzenia`, `data_smierci`) " +
                "VALUES ('" + INPUT_IMIE.Text + "','" + INPUT_NAZWISKO.Text + "'," +
                INPUT_DATA_U.Value.Year.ToString() + miesiac_u + dzien_u + "," +
                INPUT_DATA_S.Value.Year.ToString() + miesiac + dzien + ");";
            }
            else
            {
                zapytanie_autor = "INSERT INTO `autor`(`imie`, `nazwisko`, `data_urodzenia`) " +
                "VALUES ('" + INPUT_IMIE.Text + "','" + INPUT_NAZWISKO.Text + "'," +
                INPUT_DATA_U.Value.Year.ToString() + miesiac_u + dzien_u + ");";
            }


            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand dodaj_autora = new MySqlCommand(zapytanie_autor, polaczenie.conneciton);
            dodaj_autora.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_autora.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Dodano autora", "Powiadomienie");
                Dodaj_ksiazke_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void Dodaj_ksiazke_Load(object sender, EventArgs e)
        {
            INPUT_AUTOR.Items.Clear();
            INPUT_TYTUL_E.Items.Clear();

            SQL_CONNECT polaczenie = new SQL_CONNECT();

            string zapytanie_combo_autor = "SELECT autor.imie, autor.nazwisko, autor.autor_id FROM autor;";

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_dane_autor = new MySqlDataAdapter(zapytanie_combo_autor, polaczenie.conneciton);
            DataTable combobox_autor = new DataTable();

            pobierz_dane_autor.Fill(combobox_autor);

            foreach (DataRow row in combobox_autor.Rows)
            {
                string zapis = row["imie"].ToString() + " " + row["nazwisko"].ToString() + "                                                                              #" + row["autor_id"].ToString();
                INPUT_AUTOR.Items.Add(zapis);
            }
            polaczenie.conneciton.Close();

            //=============================================

            string zapytanie_combo_ksiazka = "SELECT ksiazka.tytul, ksiazka.ISBN FROM ksiazka;";

            polaczenie.conneciton.Open();

            MySqlDataAdapter pobierz_dane_ksiazka = new MySqlDataAdapter(zapytanie_combo_ksiazka, polaczenie.conneciton);
            DataTable combobox_ksiazka = new DataTable();

            pobierz_dane_ksiazka.Fill(combobox_ksiazka);

            foreach (DataRow row2 in combobox_ksiazka.Rows)
            {
                string zapis = row2["tytul"].ToString() + "                                                                              #" + row2["ISBN"].ToString();

                INPUT_TYTUL_E.Items.Add(zapis);
            }
            polaczenie.conneciton.Close();
        }

        private void BUT_EGZEMPLARZ_Click(object sender, EventArgs e)
        {
            string zlap_id_tytul = INPUT_TYTUL_E.Text.Substring(INPUT_TYTUL_E.Text.IndexOf('#') + 1);

            string zapytanie_egzemplarz = "INSERT INTO `egzemplarz`(`ksiazka_id_fk`, `dostepny`) VALUES(" + zlap_id_tytul + ", 1);";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand dodaj_egzemplarz = new MySqlCommand(zapytanie_egzemplarz, polaczenie.conneciton);
            dodaj_egzemplarz.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_egzemplarz.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Dodano egzemplarz", "Powiadomienie");
                Dodaj_ksiazke_Load(this, e);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

    }
}
