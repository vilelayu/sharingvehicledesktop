using System;
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
            DialogResult Resultado = MessageBox.Show("Se cancelar esta operação sua tela será fechada. \nDeseja realmente cancelar a operação? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close(); 
            }
            
        }

        private void TxttipoGasto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtVParcela_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtcodCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
    }
}
