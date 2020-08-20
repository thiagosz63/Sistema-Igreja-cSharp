using Sistema_Igreja.model.dao;
using Sistema_Igreja.model.dao.impl;
using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Igreja.gui
{
    public partial class frRegisterList : Form
    {
        public frRegisterList()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frRegisterForm registerform = new frRegisterForm();
            registerform.StartPosition = FormStartPosition.CenterScreen;
            registerform.ShowDialog();
        }

        private void frRegisterList_Load(object sender, EventArgs e)
        {
            try
            {
                RegisterDao registeroperacao = new RegisterOpercao();
                dgvFrRegister.DataSource = registeroperacao.select();
            }
            catch(Exception errpor)
            {
                MessageBox.Show(errpor.Message);
            }
        }
    }
}
