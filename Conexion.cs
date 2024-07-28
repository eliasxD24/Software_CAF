using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLI
{
    class Conexion
    {
        private static string servidor;
        private static string usuario;
        private static string password;
        private static string bd;
        private static string puerto;

        public static void SetConexion(string servidor_, string usuario_, string password_, string bd_, string puerto_)
        {
            servidor = servidor_;
            usuario = usuario_;
            password = password_;
            bd = bd_;
            puerto = puerto_;
        }

        public static MySqlConnection getConexion()
        {
            string cadenaConexion = "server=" + servidor + "; user id=" + usuario + "; password=" + password + "; database=" + bd + "; port=" + puerto + ";";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
    }
}
