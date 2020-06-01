using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Bibioteka_Zieja_Błoniarz
{
    class SQL_CONNECT
    {
        const string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=biblioteka_bloniarz_zieja";

        public MySqlConnection conneciton = new MySqlConnection(connectionString);
    }
}
