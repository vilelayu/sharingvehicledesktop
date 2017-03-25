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
using sharingvehicledesktop.Apresentacao;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            EscondeItemDeCadastro();
        }

        UsuarioDTO dto = new UsuarioDTO();
        UsuarioNegocio negocio = new UsuarioNegocio();

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Possibilita visualizar a senha do usuário antes de salvar, Caso queira visualizar sua senha é só selecionar o checkBox da tela. 
        /// </summary>
        private void VerificaSenha(object sender, EventArgs e)
        {
            if (CbVisualizaSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                TxtRepeteSenha.UseSystemPasswordChar = false;
            }
            else if (CbVisualizaSenha.Checked == false)
            {
                txtSenha.UseSystemPasswordChar = true;
                TxtRepeteSenha.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Menu>().Count() > 0)
            {
                this.Close();
            }
            else
            {
                Form1 volta = new Form1();
                volta.Show();
                this.Close();
            }
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            verificaCamposParaInserir();
        }


        /// <summary>
        /// Verifica campos e manda os dados para o DTO e inserir. 
        /// Para não sobrecarregar o Botão de inserção é melhor chamar só o método. 
        /// </summary>
        public void verificaCamposParaInserir()
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || TxtRepeteSenha.Text == "")
            {
                MessageBox.Show("Possui campo obrigatorio vazio, favor preencher corretamente! ", "Informação:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text != TxtRepeteSenha.Text)
            {
                MessageBox.Show("Os campos de senha não batem um com o outro. \nVerifique se realmente digitou correto!", "FALHA:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    LimparParametros();
                }
            }
        }

        private void BtnCancelaCadastroUsu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Menu>().Count() > 0)
            {
                this.Close();
            }
            else
            {
                this.Close();
                Form1 novo = new Form1();
                novo.Show();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Verifica se o Menu está aberto, caso esteva muda totalmente as funcionalidades do cadastro de usuário para redefinição de senha. 
        /// </summary>
        public void EscondeItemDeCadastro()
        {
            if (Application.OpenForms.OfType<Menu>().Count() > 0)
            {
                lblCadastroUsuario.Text = "Redefina sua senha: ";
                lblNome.Text = "Qual seu ID?";
                btConfirma.Hide();
                btnRedefinirSenha.Location = new Point(215, 273);
                btnRedefinirSenha.Visible = true;
            }
        }



        public void TrocaSenha()
        {
            try
            {
                dto.id = int.Parse(txtNome.Text);
                dto.senha = txtSenha.Text;
                negocio.AtualizarUsuario(dto);
                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Algo deu errado e não foi possível atualizar sua senha. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimparParametros();
            }
        }

        /// <summary>
        /// Limpa os parâmetros após realizar suas funções.. 
        /// </summary>
        public void LimparParametros()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            TxtRepeteSenha.Text = "";
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            TrocaSenha();
        }
    }
}
