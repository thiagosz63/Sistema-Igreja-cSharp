using Sistema_Igreja.gui.util;
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
        frRegisterForm registerform = new frRegisterForm();

        RegisterDao registerOpercao = new RegisterOpercao();

        public frRegisterList()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            registerform.clearForm();
            registerform.carregarComboBox();
            registerform.lblView.Text = "Cadastrar";
            chamarForm();
            ChamarDataGridView();
        }

        private void frRegisterList_Load(object sender, EventArgs e)
        {
            ChamarDataGridView();
        }

        private void dgvFrRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.editar.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dgvFrRegister.Rows[e.RowIndex];
                registerform.clearForm();
                // mostra o form...
                povoandoForm();
                chamarForm();
                ChamarDataGridView();
            }

            if (e.ColumnIndex == this.excluir.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dgvFrRegister.Rows[e.RowIndex];
                registerform.clearForm();
                // mostra o form...
                var result = Alerts.showAlertResult("Tem certeza que deseja Apagar " + dgvFrRegister.SelectedCells[3].Value.ToString() + ". Está operação será inrreverssivel", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.OK)
                {
                    int? id = Utils.tryParseToInt(dgvFrRegister.SelectedCells[2].Value.ToString());
                   
                    registerOpercao.deleteById(id);
                    ChamarDataGridView();
                }
            }
        }

        private void ChamarDataGridView()
        {
            try
            {
               
                dgvFrRegister.DataSource = registerOpercao.findAll();
                dgvFrRegister.DataMember = registerOpercao.findAll().Tables[0].TableName;

                dgvFrRegister.Columns[2].HeaderText = "Codigo";
                dgvFrRegister.Columns[3].HeaderText = "Nome";
                dgvFrRegister.Columns[11].HeaderText = "Congregação";
                dgvFrRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvFrRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtPesquisa.Text = null;

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void chamarForm()
        {
            registerform.StartPosition = FormStartPosition.CenterScreen;
            registerform.ShowDialog();
        }
        private void povoandoForm()
        {

            registerform.txtCod.Text = dgvFrRegister.SelectedCells[2].Value.ToString();
            registerform.txtNome.Text = dgvFrRegister.SelectedCells[3].Value.ToString();
            registerform.cmbSexo.Text = dgvFrRegister.SelectedCells[4].Value.ToString();
            registerform.txtEstCivil.Text = dgvFrRegister.SelectedCells[5].Value.ToString();
            registerform.txtEmail.Text = dgvFrRegister.SelectedCells[6].Value.ToString();
            registerform.txtRg.Text = dgvFrRegister.SelectedCells[7].Value.ToString();
            registerform.txtCpf.Text = dgvFrRegister.SelectedCells[8].Value.ToString();
            registerform.txtCargo.Text = dgvFrRegister.SelectedCells[9].Value.ToString();
            registerform.txtsituacao.Text = dgvFrRegister.SelectedCells[10].Value.ToString();
            registerform.cmbCongregacao.Text = dgvFrRegister.SelectedCells[11].Value.ToString();
            registerform.lblView.Text = "Atualizar";

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPesquisa_Click(object sender, EventArgs e)
        {
            cbPesquisa.Items.Clear();
            cbPesquisa.Items.Add("nome");
            cbPesquisa.Items.Add("sexo");
            cbPesquisa.Items.Add("estado_civil");
            cbPesquisa.Items.Add("email");
            cbPesquisa.Items.Add("rg");
            cbPesquisa.Items.Add("cpf");
            cbPesquisa.Items.Add("cargo");
            cbPesquisa.Items.Add("situacao");
            cbPesquisa.Items.Add("congregacao");
            cbPesquisa.Items.Add("dirigente");      
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text != "")
            {
                
                try
                {
                    
                    dgvFrRegister.DataSource = registerOpercao.search(cbPesquisa.Text, txtPesquisa.Text);
                    dgvFrRegister.DataMember = registerOpercao.search(cbPesquisa.Text, txtPesquisa.Text).Tables[0].TableName;

                    dgvFrRegister.Columns[2].HeaderText = "Codigo";
                    dgvFrRegister.Columns[3].HeaderText = "Nome";
                    dgvFrRegister.Columns[11].HeaderText = "Congregação";
                    dgvFrRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvFrRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}

