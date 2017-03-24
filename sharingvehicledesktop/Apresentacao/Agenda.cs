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

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            try
            {
                dtoAgenda.id = int.Parse(txtID.Text);
                dtoAgenda.idCar = int.Parse(txtCodigoVeiculo.Text);
                dtoAgenda.idMotorista = int.Parse(txtCodigoMotorista.Text);
                dtoAgenda.horario = DateTime.Parse(txtHora.Text);
                dtoAgenda.dia = DateTime.Parse(txtDia.Text);
                NegocioAgenda.InserirAgenda(dtoAgenda);
            }
            catch
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                LimpaCampos();
                caregaGrid();
            }
               
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            txtDia.Text = "";
            txtHora.Text = "";
            txtID.Text = "";
            txtCodigoVeiculo.Text = "";
            txtCodigoMotorista.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDia.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHora.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCodigoMotorista.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCodigoVeiculo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
        private void caregaGrid()
        {
            ConfigDataGrid grid = new ConfigDataGrid();
            dataGridView1.DataSource = grid.SelecionaDia();
        }
    }
}
