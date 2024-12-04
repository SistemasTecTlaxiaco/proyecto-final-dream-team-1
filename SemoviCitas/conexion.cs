using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SemoviCitas
{
    class conexion
    {
        public static MySqlConnection conectarabd()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=semovi;UID=root;PASSWORDS=;");
            conectar.Open();
            return conectar;

        }
    }
}
