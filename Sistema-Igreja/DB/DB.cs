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

        private MySqlConnection conn = new MySqlConnection();

        //Construtor
        public DB()
        {
            conn.ConnectionString = ("Server = 10.0.0.102; Port = 3306; Database = IGREJA_SHEKINAH; Uid = root; Pwd = 872037");


        }

        //Metodo Conectar
        public  MySqlConnection conectar()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (MySqlException e)
            {
                Alerts.showAlert(e.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;

        }

        //Metodo Desconectar
        public  void desconectar()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (MySqlException e)
            {
                 Alerts.showAlert(e.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
