using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Igreja.gui.util
{
    class Alerts
    {
      
        public static void showAlert(String mensagem, string titulo, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
             MessageBox.Show(mensagem, titulo, buttons, icon);

        }

        public static DialogResult showAlertResult(String mensagem, string titulo, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            result = MessageBox.Show(mensagem, titulo, buttons, icon);
            return result;
        }
    }
}
