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

namespace sharingvehicledesktop.Apresentacao
{
    public partial class Menu : Form
    {
        

        public Menu(string dto)
        {
            InitializeComponent();
            label1.Text = label1.Text+dto+"!";
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
    }
}
