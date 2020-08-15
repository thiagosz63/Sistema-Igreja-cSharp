using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_Igreja.gui;

namespace Sistema_Igreja.gui
{
    public partial class frRegister : Form
    {
        public frRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoIserir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;user Id=root;database=IGREJA_SHEKINAH; password=eu3226");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into pessoas (idpessoa, nome, sexo, estado_civil, email, rg, cpf, cargo, situacao,id_igrejas) values (null,?,?,?,?,?,?,?,?,?)", objcon);
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                objCmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cmbSexo.SelectedItem.ToString();
                objCmd.Parameters.Add("@estado_civil", MySqlDbType.VarChar, 20).Value = txtEstCivil.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = txtEmail.Text;
                objCmd.Parameters.Add("@rg", MySqlDbType.VarChar, 15).Value = txtRg.Text;
                objCmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 15).Value = txtCpf.Text;
                objCmd.Parameters.Add("@cargo", MySqlDbType.VarChar, 30).Value = txtCargo;
                objCmd.Parameters.Add("@situacao", MySqlDbType.VarChar, 30).Value = txtsituacao.Text;
                objCmd.Parameters.Add("@id_igrejas", MySqlDbType.Int16, 5).Value = txtcong.Text;

                objCmd.ExecuteNonQuery();


                MessageBox.Show("Cadastro Realizado com sucesso! :)");

                objcon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou" + erro);
            }
        }
        private void frRegister_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }
    }
}
