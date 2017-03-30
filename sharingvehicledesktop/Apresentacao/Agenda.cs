using System;
using System.Windows.Forms;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.Negocios;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            caregaGrid();
        }

        AgendaDTO dtoAgenda = new AgendaDTO();
        AgendaNegocio NegocioAgenda = new AgendaNegocio();

        public void SalvaDados()
        {
            
        }
        public void LimpaCampos()
        {
           
        }
        
        
        private void caregaGrid()
        {
            ConfigDataGrid grid = new ConfigDataGrid();
            dataGridView1.DataSource = grid.SelecionaDia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btcancela_Click(object sender, EventArgs e)
        {
            DialogResult Retorno = MessageBox.Show("Deseja realmente cancelar a opração? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Retorno == DialogResult.Yes)
            {
                this.Close();
            }
            else LimpaCampos();
        }
        /// <summary>
        /// transmite o codigo do veiculo selecionado para o campo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodveiculo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
