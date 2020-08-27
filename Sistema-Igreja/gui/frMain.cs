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
using Sistema_Igreja.model.dao.impl;
using Sistema_Igreja.model.entitie;

namespace Sistema_Igreja
{
    public partial class frMain : Form
    {
        private frLogin frlogin;
        private Form form;

        public frMain()
        {
            InitializeComponent();
            frlogin = new frLogin(this);

        }

        private void frMain_Load(object sender, EventArgs e)
        {
            frlogin.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form?.Close();
            frlogin.ShowDialog();
        }
        private void igrejaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroPessoas_Click(object sender, EventArgs e)
        {
            frRegisterList chamar = new frRegisterList();
            this.Hide();
            chamar.ShowDialog();
        }
        private void btnIgrejas_Click(object sender, EventArgs e)
        {
            frIgrejaList chamar2 = new frIgrejaList();
            this.Hide();
            chamar2.ShowDialog();
        }
    }
}
