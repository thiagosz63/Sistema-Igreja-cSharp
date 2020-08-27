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
    public partial class frIgrejaList : Form
    {
        frIgrejaForm igrejaform = new frIgrejaForm();
        public frIgrejaList()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
