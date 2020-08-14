using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Igreja.gui;

namespace Sistema_Igreja
{
    public partial class frMain : Form
    {
        frLogin frlogin;

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
            frlogin.ShowDialog();
        }
    }
}
