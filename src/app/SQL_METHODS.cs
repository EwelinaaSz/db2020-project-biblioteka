using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Bibioteka_Zieja_Błoniarz
{
    class SQL_METHODS
    {
        public DataTable List_All_Users()
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

            return lista;
        }

        public DataTable List_All_Books()
        {
            DataTable lista = new DataTable();
            return lista;
        }
    }
}
