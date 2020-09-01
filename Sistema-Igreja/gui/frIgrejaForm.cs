using Sistema_Igreja.gui.util;
using Sistema_Igreja.model.dao.impl;
using System;
using System.Windows.Forms;
using Sistema_Igreja.model.entitie;
using RegisterIgreja = Sistema_Igreja.model.entitie.RegisterIgreja;
using Sistema_Igreja.model.dao;

namespace Sistema_Igreja.gui
{
    public partial class frIgrejaForm : Form
    {
        IgrejaDao igrejaoperacao = new IgrejaOperacao();
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
            dateinaugurada.Text = null;
            cmbTipo2.Items.Clear();
        }
        public void carregarComboBox2()
        {
            cmbTipo2.Text = "Selecione";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            RegisterIgreja igrejaOpe = new RegisterIgreja(Utils.tryParseToInt(txtCod2.Text), txtCongregacao.Text,
                                       txtDirigente.Text, txtRua2.Text, txtNumero2.Text, txtBairro2.Text, txtCidade2.Text,
                                       txtEstado2.Text, mastxtboxTelef2.Text, cmbTipo2.Text, dateinaugurada.Text);


            if (Utils.tryParseToInt(txtCod2.Text) == null)
            {

                if (igrejaoperacao.insertIgreja(igrejaOpe) == 1)
                {
                    clearFormIgreja();
                    carregarComboBox2();
                }
            }
            else
            {
                igrejaoperacao.updateIgreja(igrejaOpe);
                this.Close();
            }
        }

        private void cmbTipo2_Click(object sender, EventArgs e)
        {
            cmbTipo2.Items.Clear();
            cmbTipo2.Items.Add("RES");
            cmbTipo2.Items.Add("COM");
            cmbTipo2.Items.Add("CEL");
        }
    }
}
