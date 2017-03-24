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
            label1.Text = label1.Text+dto+"!";
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

            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

      

        private void abastecimetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCombustivel abastecer = new CadastroCombustivel();
            abastecer.Show();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCar car = new CadastroCar();
            car.Show();
        }

        

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMotorista motorista = new CadastroMotorista();
            motorista.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGasto gasto = new CadastroGasto();
            gasto.Show();
        }

        private void mapaGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisasNoMapa pesquisa = new PesquisasNoMapa();
            pesquisa.Show();
        }

        private void questionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            questionario tela = new questionario();
            tela.Show();
        }

      

        private void deslocamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deslocamento NovoDeslocamento = new Deslocamento();
            NovoDeslocamento.Show(); 
        }
                

        private void rateioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RateioDosGastos Rateio = new RateioDosGastos(); 
            Rateio.Show();
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
            Agenda agenda = new Agenda();
            agenda.Show();
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
            CadastroUsuario MudarSenha = new CadastroUsuario();
            MudarSenha.Show();        
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
    }
}
