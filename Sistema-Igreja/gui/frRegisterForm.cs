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
using Sistema_Igreja.gui.util;
using Sistema_Igreja.model.dao;
using Sistema_Igreja.model.dao.impl;
using Sistema_Igreja.model.entitie;

namespace Sistema_Igreja.gui
{
    public partial class frRegisterForm : Form
    {
        public frRegisterForm()
        {
            InitializeComponent();
        }

        private void frRegister_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbCongregacao.Items.Add("1");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Register register = new Register(Utils.tryParseToInt(txtCod.Text),txtNome.Text, cmbSexo.SelectedItem.ToString(),
                txtEstCivil.Text, txtEmail.Text,txtCargo.Text, txtRg.Text, txtCpf.Text,txtsituacao.Text, Utils.tryParseToInt(cmbCongregacao.Text));
            RegisterDao registeroperacao = new RegisterOpercao();

            if (Utils.tryParseToInt(txtCod.Text) == null)
            {
               
                registeroperacao.insert(register);
            }
            else
            {
                registeroperacao.update(register);
            }
            clearForm();

        }

        private void clearForm()
        {
            txtCod.Text = null;
            txtNome.Text = null;
            txtEstCivil.Text = null;
            txtEmail.Text = null;
            txtCargo.Text = null;
            txtRg.Text = null;
            txtCpf.Text = null;
            txtsituacao.Text = null;  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
