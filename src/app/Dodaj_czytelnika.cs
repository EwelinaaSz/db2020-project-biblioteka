using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Bibioteka_Zieja_Błoniarz
{
    public partial class Dodaj_czytelnika : Form
    {
        public Dodaj_czytelnika()
        {
            InitializeComponent();
        }

        private void DODAJ_Click(object sender, EventArgs e)
        {
            string zapytanie_adres = "INSERT INTO `adres`(`ulica`, `nr_domu`, `kod_pocztowy`, `miasto`) " +
                "VALUES ('" + INPUT_ULICA.Text + "'," + INPUT_DOM.Text + "," + INPUT_KOD_1.Text + INPUT_KOD_2.Text + ",'" + INPUT_MIASTO.Text + "');";

            string zapytanie_czytelnik = "INSERT INTO `czytelnik`( `imie`, `nazwisko`, `nr_telefonu`, `e_mail`, `adres_id_fk`) " +
                "VALUES ('" + INPUT_IMIE.Text + "','" + INPUT_NAZWISKO.Text + "'," + INPUT_TELEFON.Text + ",'" + INPUT_MAIL.Text + "', (SELECT MAX(adres_id) FROM adres));";

            SQL_CONNECT polaczenie = new SQL_CONNECT();
            MySqlCommand dodaj_czytelnika = new MySqlCommand(zapytanie_czytelnik, polaczenie.conneciton);
            MySqlCommand dodaj_adres = new MySqlCommand(zapytanie_adres, polaczenie.conneciton);
            
            dodaj_adres.CommandTimeout = 60;
            dodaj_czytelnika.CommandTimeout = 60;


            try
            {
                polaczenie.conneciton.Open();
                MySqlDataReader myReader = dodaj_adres.ExecuteReader();
                polaczenie.conneciton.Close();

                polaczenie.conneciton.Open();
                MySqlDataReader myReader_2 = dodaj_czytelnika.ExecuteReader();
                polaczenie.conneciton.Close();

                MessageBox.Show("Dodano użytkownika", "Powiadomienie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

    }
        
}
