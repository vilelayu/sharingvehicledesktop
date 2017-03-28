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
using sharingvehicledesktop.Apresentacao;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class Menu : Form
    {

        public Menu(string dto)
        {
            InitializeComponent();
            label1.Text = label1.Text + dto + "!";
            OcultaBradesco();
            BtnMinimizaWebBradesco.Visible = false;          
        }

        public Menu()
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Confirmando você sairá do sistema. \nDeseja relamente sair do sistema? ", "Aviso :(", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Form1 log = new Form1();
                log.Show();
                this.Close();
            }
        }



        private void abastecimetoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Application.OpenForms.OfType<CadastroCombustivel>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro de combustível já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastroCombustivel abastecer = new CadastroCombustivel();
                abastecer.Show();
            }
            }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (Application.OpenForms.OfType<CadastroCar>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro de veículo já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastroCar car = new CadastroCar();
                car.Show();
            }
            }



        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Application.OpenForms.OfType<CadastroMotorista>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro de motorista já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastroMotorista motorista = new CadastroMotorista();
                motorista.Show();
            }
            }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<CadastroGasto>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro de gasto já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastroGasto gasto = new CadastroGasto();
                gasto.Show();
            }
            }

        private void mapaGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (Application.OpenForms.OfType<PesquisasNoMapa>().Count() > 0)
            {
                MessageBox.Show("A tela para pesquisar no mapa já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PesquisasNoMapa pesquisa = new PesquisasNoMapa();
                pesquisa.Show();
            }
            }

        private void questionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (Application.OpenForms.OfType<questionario>().Count() > 0)
            {
                MessageBox.Show("A tela de quesstionário já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                questionario tela = new questionario();
                tela.Show();
            }
            }



        private void deslocamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (Application.OpenForms.OfType<Deslocamento>().Count() > 0)
            {
                MessageBox.Show("A tela de deslocamento já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Deslocamento NovoDeslocamento = new Deslocamento();
                NovoDeslocamento.Show();
            }
            }


        private void rateioToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (Application.OpenForms.OfType<RateioDosGastos>().Count() > 0)
            {
                MessageBox.Show("A tela de rateio já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                RateioDosGastos Rateio = new RateioDosGastos();
                Rateio.Show();
            }
            }

        /// <summary>
        /// Mostra site do bradesco.
        /// </summary>
        public void RealizaSeguro()
        {
            webBradesco.Visible = true;
            string url = "http://www.bradescoseguros.com.br/wps/portal/TransforDigital/Site/Produtos/Auto";
            webBradesco.Navigate(url);
            LabelImagineCup.Show();
            LabelContrataSeguro.Hide();
            BtnFacebook.Hide();
        }

        private void contrateUmSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizaSeguro();
            BtnMinimizaWebBradesco.Visible = true;
        }

        public void OcultaBradesco()
        {
            webBradesco.Hide();
            LabelImagineCup.Hide();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Application.OpenForms.OfType<Agenda>().Count() > 0)
            {
                MessageBox.Show("A tela de agendamento já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                Agenda agenda = new Agenda();
                agenda.Show();
            }
            }

        private void BtnMinimizaWebBradesco_Click(object sender, EventArgs e)
        {
            BtnMinimizaWebBradesco.Visible = false;
            webBradesco.Hide();
            LabelImagineCup.Visible = false;
            BtnFacebook.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Application.OpenForms.OfType<CadastroUsuario>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro de usuário já está em exibição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastroUsuario MudarSenha = new CadastroUsuario();
                MudarSenha.Show();
            }
            }

        /// <summary>
        /// Abre a página do projeto no facebook através do navegador da máquina. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Sharingvehicle/");
        }     
        
        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
