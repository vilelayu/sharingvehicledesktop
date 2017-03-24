using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharingvehicledesktop.BancoDados;
using System.Data;

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
                dt = bd.RetDataTable("SELECT * from agenda");
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar consultar as revisões: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
    }
}
