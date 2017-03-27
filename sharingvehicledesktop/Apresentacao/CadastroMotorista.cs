using System;
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
            SalvarDados();
        }

        public void SalvarDados()
        {
            dto.cnh = txtCnh.Text;
            dto.cpf = txtcpf.Text;
            dto.dataNascimento = Convert.ToString( datanasc.Text);
            dto.dataVencimentoCnh =Convert.ToString(datavenc.Text);
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
