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

namespace sharingvehicledesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // txtSenha.PasswordChar = '*';
        }

        UsuarioDTO dto = new UsuarioDTO();
        UsuarioNegocio negocio = new  UsuarioNegocio();

        private void button2_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CadastroUsuario usu = new CadastroUsuario();
            usu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.nome = txtUsuario.Text;
            dto.senha = txtSenha.Text;
            if (negocio.PesquisaLogin(dto) == "Acesso Permitido")
            {
                Apresentacao.Menu menu = new Apresentacao.Menu(dto);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou usuario  errado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
