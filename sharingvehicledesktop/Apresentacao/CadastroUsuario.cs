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
            Form1 volta = new Form1();
            volta.Show();
            this.Close();
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
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    TxtRepeteSenha.Text = "";
                }
            }
        }

        private void BtnCancelaCadastroUsu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 novo = new Form1();
            novo.Show(); 
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
