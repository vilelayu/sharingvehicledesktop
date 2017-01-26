using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.Negocios;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class CadastroGasto : Form
    {
        public CadastroGasto()
        {
            InitializeComponent();
        }

        GastoDTO dto = new GastoDTO();
        GastoNegocio negocio = new GastoNegocio();

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dto.idCar = txtcodCar.Text;
            dto.numeroParcela = txtNParcelas.Text;
            dto.tipoGasto = TxttipoGasto.Text;
            dto.valorParcela =Convert.ToDouble( txtVParcela.Text);
            MessageBox.Show(negocio.InserirGasto(dto));
            limpaCampos();
        }

        private void btVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpaCampos()
        {
            txtcodCar.Text = "";
            txtNParcelas.Text = "";
            TxttipoGasto.Text = "";
            txtVParcela.Text = "";
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
    }
}
