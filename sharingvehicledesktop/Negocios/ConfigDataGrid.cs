using System;
using sharingvehicledesktop.BancoDados;
using System.Data;
using System.Windows.Forms; 

namespace sharingvehicledesktop.Negocios
{
    class ConfigDataGrid
    {
        AcessoBancoDados2 bd = new AcessoBancoDados2();
        public DataTable SelecionaDia()
        {
            try
            {
                DataTable dt = new DataTable();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT id, marca, modelo,placa ,quilometragem from carro");
                return dt;
            }

            catch (Exception ex)
            {
                 MessageBox.Show("Erro ao tentar consultar as revisões: \n" + ex.Message); 
                throw new Exception("Erro ao tentar consultar as revisões: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        public DataTable SelecionaRateio()
        {
            try
            {
                DataTable dt = new DataTable();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from rateio");
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar consultar as revisões: \n" + ex.Message); 
                throw new Exception("Erro ao tentar consultar as revisões: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
    }
}
