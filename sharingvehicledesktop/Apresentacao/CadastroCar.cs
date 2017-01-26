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
    public partial class CadastroCar : Form
    {
        public CadastroCar()
        {
            InitializeComponent();
            cbcombustivel.Items.Add ( "Etanol");
            cbcombustivel.Items.Add("Flex");
            cbcombustivel.Items.Add("Gás");
            cbcombustivel.Items.Add("Gasolina");

        }

        CarroDTO dto = new CarroDTO();
        CarroNegocio negocio = new CarroNegocio();

        private void btsalvar_Click(object sender, EventArgs e)
        {
            dto.combustivel = cbcombustivel.Text;
            dto.cor = txtcor.Text;
            dto.marca = txtMarca.Text;
            dto.modelo = txtmodelo.Text;
            dto.placa = txtplaca.Text;
            dto.quilometragem = txtquilometragem.Text;
            dto.Renavam = txtrenavam.Text;
            MessageBox.Show(negocio.InserirVeiculo(dto));
            limpaCampos();
        }

        private void limpaCampos()
        {
            cbcombustivel.Text = "";
            txtrenavam.Text = "";
            txtquilometragem.Text = "";
            txtplaca.Text = "";
            txtmodelo.Text = "";
            txtMarca.Text = "";
            txtcor.Text = "";
        }

        private void btcancela_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
