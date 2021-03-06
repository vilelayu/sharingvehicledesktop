﻿using System;
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
            VerificaLogin();
        }

        public void VerificaLogin()
        {
            dto.nome = txtUsuario.Text;
            dto.senha = txtSenha.Text;

            if (negocio.PesquisaLogin(dto) == "Acesso Permitido")
            {
                Apresentacao.Menu menu = new Apresentacao.Menu(txtUsuario.Text);
                menu.Show();
                this.Hide();
            }           
            else if (negocio.PesquisaLogin(dto) == "O usuário ou a senha estão incorretos!")
            {
                MessageBox.Show("Senha ou usuario incorreto! \nVerifique os dados, tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar ao Banco! Tente novamente mais tarde...", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
