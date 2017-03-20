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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        AgendaDTO dtoAgenda = new AgendaDTO();
        AgendaNegocio NegocioAgenda = new AgendaNegocio();

        public void SalvaDados()
        {
            dtoAgenda.id = int.Parse(txtID.Text);
            dtoAgenda.idCar = int.Parse(txtCodigoVeiculo.Text);
            dtoAgenda.idMotorista = int.Parse(txtCodigoMotorista.Text);
            dtoAgenda.horario = DateTime.Parse(txtHora.Text);
            dtoAgenda.dia = DateTime.Parse(txtDia.Text);
        }

        private void btnSalvarAgenda_Click(object sender, EventArgs e)
        {
            SalvaDados();
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
    }
}
