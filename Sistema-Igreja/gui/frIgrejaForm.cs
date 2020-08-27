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
    public partial class frIgrejaForm : Form
    {
        public frIgrejaForm()
        {
            InitializeComponent();
        }

        public void clearFormIgreja()
        {
            txtCod2.Text = null;
            txtCongregacao.Text = null;
            txtDirigente.Text = null;
            txtRua2.Text = null;
            txtNumero2.Text = null;
            txtBairro2.Text = null;
            txtCidade2.Text = null;
            txtEstado2.Text = null;
            mastxtboxTelef2.Text = null;
            cmbTipo2.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void carregarComboBox2()
        {
            cmbTipo2.Text = "Selecione";
        }

        private void cmbTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo2.Items.Clear();
            cmbTipo2.Items.Add("Res");
            cmbTipo2.Items.Add("Com");
            cmbTipo2.Items.Add("Cel");
        }
    }
}
