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
    public partial class relatorioDeVistoria : Form
    {
        public relatorioDeVistoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este método encaminha o Relatório para a tela e exibe os dados para os usuários.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void relatorioDeVistoria_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
