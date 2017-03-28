using System;
using System.Windows.Forms;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.Negocios;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class Deslocamento : Form
    {
        public Deslocamento()
        {
            InitializeComponent();
        }
        DeslocamentoDTO dto = new DeslocamentoDTO();
        DeslocamentoNegocio negocio = new DeslocamentoNegocio();

        /// <summary>
        /// botão responsavel de salvar os dados inseridos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalarDeslocamento_Click(object sender, EventArgs e)
        {
            dto.data =  txtDataDeslocamento.Text;
            dto.idCar =int.Parse( txtIdCarroDeslocamento.Text);
            dto.idMotorista= int.Parse(txtIdMotoristaDeslocamento.Text);
            dto.quilometragemDeslocada = int.Parse(txtQuilometragemDeslocamento.Text);
            MessageBox.Show(negocio.InserteDeslocamento(dto));
            limpaCampos();

        }

        /// <summary>
        /// responsavel para fechar o formulario e voltar ao menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// apaga todos os dados digitados no formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        /// <summary>
        /// apaga todos os dados
        /// </summary>
        private void limpaCampos()
        {
            txtQuilometragemDeslocamento.Text = "";
            txtIdMotoristaDeslocamento.Text = "";
            txtIDdeslocamento.Text = "";
            txtIdCarroDeslocamento.Text = "";
            txtDataDeslocamento.Text = "";
        }

        /// <summary>
        /// responsavel a mudar os dados ja cadastrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btanAtualizarDeslocamento_Click(object sender, EventArgs e)
        {
            dto.id = int.Parse(txtIDdeslocamento.Text);
            dto.data = txtDataDeslocamento.Text;
            dto.idCar = int.Parse(txtIdCarroDeslocamento.Text);
            dto.idMotorista = int.Parse(txtIdMotoristaDeslocamento.Text);
            dto.quilometragemDeslocada = int.Parse(txtQuilometragemDeslocamento.Text);
            MessageBox.Show(negocio.AlteraDeslocamento(dto));
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Retorno = MessageBox.Show("Deseja realmente cancelar a operação? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
