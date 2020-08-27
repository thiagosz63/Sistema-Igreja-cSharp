using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Igreja.db;
using System.Data;
using System.Windows.Forms;
using Sistema_Igreja.gui.util;

namespace Sistema_Igreja.model.dao.impl
{
    class RegisterIgreja : RegisterIgrejaDao
    {
        MySqlCommand cmd = new MySqlCommand();

        public int insertIgreja(entitie.RegisterIgreja obj) {
            try
            {

                cmd.CommandText = "insert into igrejas (congregacao, dirigente, rua, numero, bairro, cidade, estado, telefone," +
                                    " tipo) " +
                                    "values(?,?,?,?,?,?,?,?,?)";


                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Congregacao;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Dirigente;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.Rua;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Numero;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Bairro;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cidade;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Estado;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Telefone;
                cmd.Parameters.Add("9", MySqlDbType.VarChar, 30).Value = obj.Tipo;

                cmd.Connection = DB.conectar();
                cmd.ExecuteNonQuery();


                Alerts.showAlert("Dados Cadastrados com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            catch (Exception e)
            {
                Alerts.showAlert(e.Message, "Falha ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cmd.Parameters.Clear();

                DB.desconectar();
            }
        }

        public void updateIgreja(entitie.RegisterIgreja obj)
        {
            try
            {
                cmd.CommandText = "UPDATE igreja_shekinah.igrejas SET congregacao = ?, dirigente = ?, rua = ?, numero = ?, " +
                                     "bairro = ?, cidade = ?, estado = ?, telefone = ?, tipo = ? WHERE(idigrejas = ?)";

                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Congregacao;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Dirigente;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.Rua;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Numero;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Bairro;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cidade;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Estado;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Telefone;
                cmd.Parameters.Add("9", MySqlDbType.VarChar, 30).Value = obj.Tipo;
                cmd.Parameters.Add("10", MySqlDbType.Int16, 5).Value = obj.Cod;

                cmd.Connection = DB.conectar();
                cmd.ExecuteNonQuery();

                Alerts.showAlert("Dados Atualizados com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception e)
            {

                Alerts.showAlert(e.Message, "Falha ao Atualiza", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.desconectar();
            }

        }

        public DataSet findAllIgreja()
        {
            try
            {

                cmd.CommandText = "select pessoas.*,igrejas.dirigente from pessoas" +
                                  " inner join igrejas on  congregacao = pessoas.id_congregacao";
                cmd.Connection = DB.conectar();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DB.desconectar();
            }
        }
    }
}
