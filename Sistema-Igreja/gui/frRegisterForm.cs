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
using Sistema_Igreja.gui.util;
using Sistema_Igreja.model.dao;
using Sistema_Igreja.model.dao.impl;
using Sistema_Igreja.model.entitie;

namespace Sistema_Igreja.gui
{
    public partial class frRegisterForm : Form
    {
        RegisterDao registeroperacao = new RegisterOpercao();
        public frRegisterForm()
        {
            InitializeComponent();
        }

        private void frRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Register register = new Register(Utils.tryParseToInt(txtCod.Text),txtNome.Text, cmbSexo.Text,
                txtEstCivil.Text, txtEmail.Text,txtCargo.Text, txtRg.Text, txtCpf.Text,txtsituacao.Text,cmbCongregacao.Text);
            

            if (Utils.tryParseToInt(txtCod.Text) == null)
            {

                if (registeroperacao.insert(register) == 1)
                {
                    clearForm();
                    carregarComboBox();
                }
            }
            else
            {
                registeroperacao.update(register);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearForm()
        {
            txtCod.Text = null;
            txtNome.Text = null;
            txtEstCivil.Text = null;
            txtEmail.Text = null;
            txtCargo.Text = null;
            txtRg.Text = null;
            txtCpf.Text = null;
            txtsituacao.Text = null;
            cmbSexo.Items.Clear();
            cmbCongregacao.DataSource = null;        
        }
        public void carregarComboBox()
        {
            cmbSexo.Text = "Selecione";
            cmbCongregacao.Text = "Selecione";        
        }

        private void cmbCongregacao_Click(object sender, EventArgs e)
        {

            cmbCongregacao.DataSource = registeroperacao.findByComboBox().Tables[0];
            cmbCongregacao.DisplayMember = "congregacao";
            
        }

        private void cmbSexo_Click(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }
    }
}
