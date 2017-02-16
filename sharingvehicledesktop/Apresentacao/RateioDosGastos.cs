using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharingvehicledesktop.Apresentacao
{
    public partial class RateioDosGastos : Form
    {
        public RateioDosGastos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que instancia o funcionamento da barra de progresso no sistema. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoverProgressBar(object sender, EventArgs e)
        {
            int contar = 1;
            //
            // Mover a progress bar através da alteração do VALUE.
            //
            progressBar1.Value = 0;     // Esse é o valor da progress bar ela vai de 0 a Maximum (padrão 100)
            progressBar1.Maximum = 1000; // Esse é o valor Maximo da progress bar, então quando value for = a 1000 ele vai ter carregado 100% (Por parão o maximum = 100)
            while (contar <= 1000)
            {
                progressBar1.Value = contar;
                contar++;
            }

            //
            // Mover a progress bar através do metodo PerformStep
            //
            progressBar1.Maximum = 1000;
            progressBar1.Step = 1;      // Esse é o valor que a progress bar vai subir quando você char a methodo PerformStep então ela vai ser incrementada esse valor até atingir o valor Maximum.
            progressBar1.Value = 0;
            contar = 1;
            while (contar <= 1000)
            {
                progressBar1.PerformStep();
                contar++;
            }

            FechaComponetesEexibeMensagem();  //Invoca o método para fechar a barra de progresso.        
        }

        /// <summary>
        /// Fecha a tela de Rateio e retorna para o Menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FechaComponetesEexibeMensagem()
        {
            MessageBox.Show("Os dados foram carregados!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0; //Zera a progress bar   
            button1.Hide();
            progressBar1.Hide();
        }

        private void RateioDosGastos_Load(object sender, EventArgs e)
        {

        }
    }
}
