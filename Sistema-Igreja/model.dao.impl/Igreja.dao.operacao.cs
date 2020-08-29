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
    class RegisterIgreja : IgrejaDao
    {
        MySqlCommand cmd = new MySqlCommand();

        public int insertIgreja(entitie.RegisterIgreja obj) {
            try
            {

                cmd.CommandText = "insert into igrejas (congregacao, dirigente, rua, numero, bairro, cidade," +
                                    " estado, telefone, tipo,inaugurada) " +
                                    "values(?,?,?,?,?,?,?,?,?,?)";


                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Congregacao;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Dirigente;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.Rua;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Numero;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Bairro;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cidade;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Estado;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Telefone;
                cmd.Parameters.Add("9", MySqlDbType.VarChar, 30).Value = obj.Tipo;
                cmd.Parameters.Add("10", MySqlDbType.VarChar, 10).Value = obj.Inaugurada;

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
                                     "bairro = ?, cidade = ?, estado = ?, telefone = ?, tipo = ?, inaugurada = ? WHERE(idigrejas = ?)";

                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Congregacao;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Dirigente;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.Rua;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Numero;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Bairro;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cidade;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Estado;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Telefone;
                cmd.Parameters.Add("9", MySqlDbType.VarChar, 30).Value = obj.Tipo;
                cmd.Parameters.Add("10", MySqlDbType.VarChar, 10).Value = obj.Inaugurada;
                cmd.Parameters.Add("11", MySqlDbType.Int16, 5).Value = obj.Cod;

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

                cmd.CommandText = "SELECT  I.CONGREGACAO,I.DIRIGENTE,T.NUMERO,T.TIPO,E.RUA,	E.NUMERO, E.BAIRRO," +
                    "E.CIDADE,E.ESTADO FROM IGREJAS I" +
                    " INNER JOIN TELEFONE T ON I.IDIGREJAS = T.ID_IGREJAS " +
                    "INNER JOIN ENDERECO E ON I.IDIGREJAS = E.ID_IGREJAS ";
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

        public void deleteByIdIgrejas(int? obj)
        {
            try
            {
                cmd.CommandText = "DELETE FROM igreja_shekinah.igrejas WHERE(idigrejas = ?)";
                cmd.Parameters.Add("1", MySqlDbType.Int16, 5).Value = obj;
                cmd.Connection = DB.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Alerts.showAlert(e.Message, "Falha ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Parameters.Clear();
                DB.desconectar();
            }
        }
        public DataSet search2(String coluna, String pesquisa)
        {
            try
            {

                cmd.CommandText = "SELECT  I.CONGREGACAO,I.DIRIGENTE,T.NUMERO,T.TIPO,E.RUA,	E.NUMERO, E.BAIRRO," +
                    "E.CIDADE,E.ESTADO FROM IGREJAS I" +
                    " INNER JOIN TELEFONE T ON I.IDIGREJAS = T.ID_IGREJAS " +
                    "INNER JOIN ENDERECO E ON I.IDIGREJAS = E.ID_IGREJAS " +
                                " where " + coluna + " like " + "'" + pesquisa + "%" + "'";
                cmd.Connection = DB.conectar();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                DB.desconectar();
            }
        }
    }
}
