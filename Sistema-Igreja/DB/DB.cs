using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_Igreja.gui.util;

namespace Sistema_Igreja.db
{

    class DB
    {

        private static MySqlConnection conn = null;

        //Metodo Conectar
        public static MySqlConnection conectar()
        {

            if (conn == null)
            {
                try
                {              
                    conn = new MySqlConnection();
                    conn.ConnectionString = ("Server = 10.0.0.102; Port = 3306; Database = IGREJA_SHEKINAH; Uid = root; Pwd = 872037");
                    conn.Open();

                }
                catch (MySqlException e)
                {
                    Alerts.showAlert(e.Message, "MySqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return conn;

        }

        //Metodo Desconectar
        public static void desconectar()
        {
            if (conn != null)
            {
                try
                {             
                    conn.Close();
                    conn = null;
                }
                catch (MySqlException e)
                {
                    Alerts.showAlert(e.Message, "MySqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
