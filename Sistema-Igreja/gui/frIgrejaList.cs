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
        IgrejaDao igrejaOperacao = new IgrejaOperacao();

        public frIgrejaList()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            igrejaform.clearFormIgreja();
            igrejaform.carregarComboBox2();
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
                dgvFrIgreja.DataSource = igrejaOperacao.findAllIgreja();
                dgvFrIgreja.DataMember = igrejaOperacao.findAllIgreja().Tables[0].TableName;

                dgvFrIgreja.Columns[4].HeaderText = "FONE";
                dgvFrIgreja.Columns[7].HeaderText = "Nº";
                dgvFrIgreja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvFrIgreja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtPesquisaIgrejas.Text = null;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvFrIgreja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.editar2.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dgvFrIgreja.Rows[e.RowIndex];
                igrejaform.clearFormIgreja();
                // mostra o form...
                povoandoFormIgreja();
                chamarFormIgrejas();
                ChamarDataGridView();
            }

            if (e.ColumnIndex == this.excluir2.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dgvFrIgreja.Rows[e.RowIndex];
                igrejaform.clearFormIgreja();
                // mostra o form...
                var result = Alerts.showAlertResult("Tem certeza que deseja Apagar " + dgvFrIgreja.SelectedCells[3].Value.ToString() + ". Está operação será inrreverssivel", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.OK)
                {
                    int? id = Utils.tryParseToInt(dgvFrIgreja.SelectedCells[2].Value.ToString());

                    igrejaOperacao.deleteByIdIgrejas(id);
                    ChamarDataGridView();
                }
            }
        }

        private void povoandoFormIgreja()
        {
            igrejaform.txtCod2.Text = dgvFrIgreja.SelectedCells[2].Value.ToString();
            igrejaform.txtCongregacao.Text = dgvFrIgreja.SelectedCells[3].Value.ToString();
            igrejaform.txtDirigente.Text = dgvFrIgreja.SelectedCells[4].Value.ToString();
            igrejaform.txtRua2.Text = dgvFrIgreja.SelectedCells[5].Value.ToString();
            igrejaform.txtNumero2.Text = dgvFrIgreja.SelectedCells[6].Value.ToString();
            igrejaform.txtBairro2.Text = dgvFrIgreja.SelectedCells[7].Value.ToString();
            igrejaform.txtCidade2.Text = dgvFrIgreja.SelectedCells[8].Value.ToString();
            igrejaform.txtEstado2.Text = dgvFrIgreja.SelectedCells[9].Value.ToString();
            igrejaform.mastxtboxTelef2.Text = dgvFrIgreja.SelectedCells[10].Value.ToString();
            igrejaform.cmbTipo2.Text = dgvFrIgreja.SelectedCells[11].Value.ToString();
            igrejaform.dateinaugurada.Text = dgvFrIgreja.SelectedCells[12].Value.ToString();
            igrejaform.lblView2.Text = "Atualizar";
        }

        
    }
}
