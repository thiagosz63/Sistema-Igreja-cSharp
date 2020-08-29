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
using Sistema_Igreja.gui.util;

namespace Sistema_Igreja.gui
{
    public partial class frIgrejaList : Form
    {
        frIgrejaForm igrejaform = new frIgrejaForm();
        IgrejaDao igrejaOperacao = new model.dao.impl.RegisterIgreja();

        public frIgrejaList()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            igrejaform.clearFormIgreja();
            igrejaform.lblView2.Text = "Cadastrar";
            chamarFormIgrejas();
            ChamarDataGridView();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chamarFormIgrejas()
        {
           igrejaform.StartPosition = FormStartPosition.CenterScreen;
            igrejaform.ShowDialog();
        }

        private void ChamarDataGridView()
        {
            try
            {
                dgvFrRegister.DataSource = igrejaOperacao.findAllIgreja();
                dgvFrRegister.DataMember = igrejaOperacao.findAllIgreja().Tables[0].TableName;

                dgvFrRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvFrRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtPesquisaIgrejas.Text = null;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
