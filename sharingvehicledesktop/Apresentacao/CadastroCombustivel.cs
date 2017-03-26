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
    public partial class CadastroCombustivel : Form
    {
        CombustivelDTO dtoCombustivel = new CombustivelDTO();

        public CadastroCombustivel()
        {
            InitializeComponent();
            CmbTipoCombustivel.Items.Add("Disel");
            CmbTipoCombustivel.Items.Add("Etanol");
            CmbTipoCombustivel.Items.Add("Gás");
            CmbTipoCombustivel.Items.Add("Gasolina ");
        }

        CombustivelNegocio combustivel = new CombustivelNegocio();

        /// <summary>
        /// Fecha a tela e retorna para o Menu se fora clicado na seta do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Invoca o método para verificar os campos e se possível cadastrar os dados no Banco. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificaCamposNulos();
            InsereDadosDeCombustivel();
        }

        /// <summary>
        /// Verifica se o usuário deseja fechar a tela e limpar os campos caso queira cancelar a operação de inserção de combustível. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja cancelar a operação e fechar a tela? ", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (DialogResult == DialogResult.No)
            {
                LimpaCampos();
            }
        }

      
        /// <summary>
        /// Limpa todos os dados informados nos campos. 
        /// </summary>
        private void LimpaCampos()
        {
            txtCodigoveiculo.Text = "";
            txtLitros.Text = "";
            txtValorAbastecimento.Text = "";
            CmbTipoCombustivel.Text = "Selecione um Combustivel";
            DataAbastecimento.Text = "";
        }

        /// <summary>
        /// Verifica os campos nulos, se os campos estiverem todos informados o Método InsereDadosDeCombustivel é acionado. 
        /// </summary>
        private void VerificaCamposNulos()
        {
            if (txtValorAbastecimento.Text == "" || txtLitros.Text == "" || txtCodigoveiculo.Text == "" || CmbTipoCombustivel.Text == "Selecione um Combustivel" || DataAbastecimento.Text == "")
            {
                MessageBox.Show(" Para prosseguir com o cadastramento deverá ser informado todos os dados. \n Preencha-os corretamente! ", "Opa, algo está errado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InsereDadosDeCombustivel();
            }
        }

        /// <summary>
        /// Insere os dados informados ao Banco. 
        /// </summary>
        private void InsereDadosDeCombustivel()
        {
            CombustivelDTO dtoCombustivel = new CombustivelDTO();
            dtoCombustivel.combustivel = CmbTipoCombustivel.Text;
            dtoCombustivel.dia = DataAbastecimento.MaxDate;
            dtoCombustivel.litro = double.Parse(txtLitros.Text);
            dtoCombustivel.valor = float.Parse(txtValorAbastecimento.Text);
            dtoCombustivel.idCar = int.Parse(txtCodigoveiculo.Text);
          MessageBox.Show( combustivel.InserirCombustivel(dtoCombustivel));
            
        }
    }
}
