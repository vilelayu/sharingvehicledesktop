using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;
using System.Data;

namespace sharingvehicledesktop.Negocios
{
    class RateioNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados(); 


        /// <summary>
        /// Método que insere os dados de Rateio dos gastos do veículo. 
        /// </summary>
        /// <param name="insere"></param>
        /// <returns></returns>
        public string InsereRateio(RateioDTO insere)
        {
           
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("DataSaida", insere.dataSaida);
                acessoDadosSqlServer.AdicionarParametros("DataRetorno", insere.dataRetorno);
                acessoDadosSqlServer.AdicionarParametros("QuilometragemUso", insere.dataRetorno);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereRateio").ToString(); 
                return retorno;  
            }
             
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }
        }

        /// <summary>
        /// Método que seleciona os dados do Rateio a partir do ID.
        /// </summary>
        /// <param name="seleciona"></param>
        /// <returns></returns>
        public string SelecionaRateioID(RateioDTO seleciona)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_id", seleciona.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdRateio").ToString();
                return retorno; 
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null; 
            }
        }

        /// <summary>
        /// Método que seleciona todos os dados a partir do comando direto do banco, SELECT * FROM rateio; 
        /// </summary>
        /// <param name="selecionaGeral"></param>
        /// <returns></returns>
        public string SelecionaRateioGeral()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdRateio").ToString();
                return retorno; 
            }
            catch(Exception exception)
            {
                return exception.Message; 
            }
            finally
            {
                acessoDadosSqlServer = null; 
            }
        }

        /// <summary>
        /// Método que deleta os dados do rateio a partir do Id. 
        /// </summary>
        /// <param name="deletaRateio"></param>
        /// <returns></returns>
        public string DeletaRateio(RateioDTO deletaRateio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_id", deletaRateio.id);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaRateio").ToString();
                return retorno; 
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null; 
            }
        }

        /// <summary>
        /// Método que atualiza os dados do rateio de acordo com o ID. 
        /// </summary>
        /// <param name="atualizaRateio"></param>
        /// <returns></returns>
        public string AtualizaRateio(RateioDTO atualizaRateio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_id", atualizaRateio.id);
                acessoDadosSqlServer.AdicionarParametros("_DataRetorno", atualizaRateio.dataRetorno); 
                acessoDadosSqlServer.AdicionarParametros("_DataSaida", atualizaRateio.dataSaida);
                acessoDadosSqlServer.AdicionarParametros("_QuilometragemUso", atualizaRateio.quilometragemUso);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarRateio").ToString();
                return retorno; 
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null; 
            }
        }
    }
}
