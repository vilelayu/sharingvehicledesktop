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
        }

        private void questionario_Load(object sender, EventArgs e)
        {
            string url = "www.facebook.com.br";
            webBrowser1.Navigate(url);
        }
    }
}
