using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_Igreja.db;
using Sistema_Igreja.gui.util;
using Sistema_Igreja.model.entitie;

namespace Sistema_Igreja.model.dao.impl
{
    class RegisterOpercao : RegisterDao
    {

        MySqlCommand cmd = new MySqlCommand();
        

        public void insert(entitie.Register obj)
        {  
            try
            {

                cmd.CommandText = "insert into pessoas (nome, sexo, estado_civil, email, rg, cpf, cargo, situacao, id_igrejas) " +
                    "values(?,?,?,?,?,?,?,?,?)";

                // cmd.Parameters.AddWithValue("1", null);
                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Nome;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Sexo;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.EstadoCivil;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Email;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Rg;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cpf;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Cargo;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Situacao;
                cmd.Parameters.Add("9", MySqlDbType.Int16, 5).Value = obj.Congregacao;

                DB db = new DB();
                cmd.Connection = db.conectar();

                cmd.ExecuteNonQuery();
                db.desconectar();

            }
            catch(Exception e)
            {
                Alerts.showAlert(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        public void update(entitie.Register obj)
        {
            throw new NotImplementedException();
        }
        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }
        public entitie.Register findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<entitie.Register> findAll()
        {
            throw new NotImplementedException();
        }

       

    
    }
}
