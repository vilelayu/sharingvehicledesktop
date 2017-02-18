using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class questionario : Form
    {
        public questionario()
        {
            InitializeComponent();
            webBrowser1.Visible = false;
            comboBox1.Items.Add("Emprestimo");
            comboBox1.Items.Add("Devolução ");
        }

        private void questionario_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Emprestimo")
            {
                webBrowser1.Visible = true;
                string url = " https://yurivilea.typeform.com/to/oBVkjT";
                webBrowser1.Navigate(url);
            }
            else
            {
                webBrowser1.Visible = true;
                string url = " https://yurivilea.typeform.com/to/oBVkjT";
                webBrowser1.Navigate(url);
            }
        }
    }
}
