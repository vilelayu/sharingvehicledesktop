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
            // Finaliza a sessão por completo após fechar o fomrulário. 
            Application.Exit(); 
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
                Apresentacao.Menu menu = new Apresentacao.Menu(txtUsuario.Text);
                menu.Show();
                this.Hide();
            }
            //Ainda precisa ser corrigido para exibição desta mensagem, o código não identifica o retorno da camada de negocio após não exibir o Acesso Permitido!
            else if (negocio.PesquisaLogin(dto) == "O usuário ou a senha estão incorretos!")
            {
                MessageBox.Show("Senha ou usuario incorreto! \nVerifique os dados novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar ao Banco! Tente novamente mais tarde..", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
