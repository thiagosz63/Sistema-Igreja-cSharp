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
    public partial class frLogin : Form
    {
        frMain frmain;

        public frLogin(frMain frmain)
        {
            InitializeComponent();
            this.frmain = frmain;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmain.Visible = true;
        }
    }
}
