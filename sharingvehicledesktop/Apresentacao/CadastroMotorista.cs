using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sharingvehicledesktop.Apresentacao;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.Negocios;


namespace sharingvehicledesktop.Apresentacao
{
    public partial class CadastroMotorista : Form
    {
        public CadastroMotorista()
        {
            InitializeComponent();
        }

        MotoristaDTO dto = new MotoristaDTO();
        MotoristaNegocio negocio = new MotoristaNegocio();

        private void btsalva_Click(object sender, EventArgs e)
        {
            dto.cnh = txtCnh.Text;
            dto.cpf = txtcpf.Text;
            dto.dataNascimento = txtnascimento.Text;
            dto.dataVencimentoCnh = txtvencimento.Text;
            dto.idUsuario = Txtid.Text;
            dto.nome = txtNome.Text;

            MessageBox.Show(negocio.InserirMotorista(dto));

            limpacampos();
        }

        private void limpacampos()
        {
            txtNome.Text = "";
            Txtid.Text = "";
            txtcpf.Text = "";
            txtCnh.Text = "";
            txtvencimento.Text = "";
            txtnascimento.Text = "";
        }

        private void btcancela_Click(object sender, EventArgs e)
        {
            limpacampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
