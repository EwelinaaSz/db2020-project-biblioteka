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
    public partial class Edytor_czytelnika : Form
    {
        string Karta_czytelnika, Adres_id;

        public Edytor_czytelnika()
        {
            InitializeComponent();
        }

        public Edytor_czytelnika(string Karta, string Adres)
        {
            InitializeComponent();

            Karta_czytelnika = Karta;
            Adres_id = Adres;
        }

        private void BUT_EDYTUJ_Click(object sender, EventArgs e)
        {
            string zapytanie_edycja_czytelnik = "UPDATE `czytelnik`, `adres`" +
            "SET `imie` = '" + INPUT_IMIE.Text + "', `nazwisko` = '" + INPUT_NAZWISKO.Text + "', `nr_telefonu` = " + INPUT_TELEFON.Text + 
            ", `e_mail` = '" + INPUT_MAIL.Text + "', adres.ulica = '" + INPUT_ULICA.Text + "', adres.nr_domu = " + INPUT_DOM.Text + 
            ", adres.kod_pocztowy = " + INPUT_KOD.Text + ", adres.miasto = '" + INPUT_MIASTO.Text + 
            "'WHERE czytelnik.adres_id_fk = adres.adres_id AND czytelnik.nr_karta_biblioteczna =" + Karta_czytelnika + " ;";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand edytuj_czytelnik = new MySqlCommand(zapytanie_edycja_czytelnik, polaczenie.conneciton);

            edytuj_czytelnik.CommandTimeout = 60;

            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = edytuj_czytelnik.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Czytelnik zedytowany", "Powiadomienie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void BUT_USUN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien?", "Potwierdzenie", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {

            }
        }
    }
}
