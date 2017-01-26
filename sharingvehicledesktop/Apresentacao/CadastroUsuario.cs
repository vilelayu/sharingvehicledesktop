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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }
        
        UsuarioDTO dto = new UsuarioDTO();
        UsuarioNegocio negocio = new UsuarioNegocio();

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 volta = new Form1();
            volta.Show();
            this.Close();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Possui campo obrigatorio vazio", "informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dto.nome = txtNome.Text;
                    dto.senha = txtSenha.Text;
                    negocio.InserirUsuario(dto);
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtNome.Text = "";
                    txtSenha.Text = "";
                }
            }
        }
    }
}
