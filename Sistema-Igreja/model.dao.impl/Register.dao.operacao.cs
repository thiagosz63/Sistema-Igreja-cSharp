using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

                cmd.CommandText = "insert into pessoas (nome, sexo, estado_civil, email, rg, cpf, cargo, situacao," +
                                    " id_igrejas) " +
                                    "values(?,?,?,?,?,?,?,?,?)";


                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Nome;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Sexo;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.EstadoCivil;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Email;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Rg;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cpf;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Cargo;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Situacao;
                cmd.Parameters.Add("9", MySqlDbType.Int16, 5).Value = obj.Congregacao;

                cmd.Connection = DB.conectar();
                cmd.ExecuteNonQuery();

                Alerts.showAlert("Dados Cadastrados com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception e)
            {
                Alerts.showAlert(e.Message, "Falha ao inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Parameters.Clear();

                DB.desconectar();
            }

        }

        public void update(entitie.Register obj)
        {
            try
            {
                cmd.CommandText = "UPDATE igreja_shekinah.pessoas SET nome = ?, sexo = ?, estado_civil = ?, email = ?, " +
                                     "rg = ?, cpf = ?, cargo = ?, situacao = ?, id_igrejas = ? WHERE(idpessoa = ?)";

                cmd.Parameters.Add("1", MySqlDbType.VarChar, 50).Value = obj.Nome;
                cmd.Parameters.Add("2", MySqlDbType.VarChar, 1).Value = obj.Sexo;
                cmd.Parameters.Add("3", MySqlDbType.VarChar, 20).Value = obj.EstadoCivil;
                cmd.Parameters.Add("4", MySqlDbType.VarChar, 30).Value = obj.Email;
                cmd.Parameters.Add("5", MySqlDbType.VarChar, 15).Value = obj.Rg;
                cmd.Parameters.Add("6", MySqlDbType.VarChar, 15).Value = obj.Cpf;
                cmd.Parameters.Add("7", MySqlDbType.VarChar, 30).Value = obj.Cargo;
                cmd.Parameters.Add("8", MySqlDbType.VarChar, 30).Value = obj.Situacao;
                cmd.Parameters.Add("9", MySqlDbType.Int16, 5).Value = obj.Congregacao;
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
        public void deleteById(Register obj)
        {
            try
            {
                cmd.CommandText = "DELETE FROM igreja_shekinah.pessoas WHERE(idpessoa = ?)";
                cmd.Parameters.Add("1", MySqlDbType.Int16, 5).Value = obj.Cod;
                cmd.Connection = DB.conectar();
                cmd.ExecuteNonQuery();
                Alerts.showAlert("Dados Deletado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                Alerts.showAlert(e.Message, "Falha ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.desconectar();
            }

        }
        public entitie.Register findById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable select()
        {
            try
            {
                //  cmd.CommandText = "select pessoas.*, igrejas.congregacao, igrejas.dirigente " +
                //      "from pessoas inner join igrejas on igrejas.idigrejas = pessoas.id_igrejas";
                cmd.CommandText = "SELECT * FROM pessoas";
                cmd.Connection = DB.conectar();         
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                dt.Fill(datatable);

                return datatable;
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
