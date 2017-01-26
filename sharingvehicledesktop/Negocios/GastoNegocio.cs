using System;
using System.Data;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;

namespace sharingvehicledesktop.Negocios
{
    class GastoNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// cadastra nos gasto do veiculo
        /// </summary>
        /// <param name="gasto"></param>
        /// <returns></returns>

        public string InserirGasto(GastoDTO gasto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Carro_ID", gasto.idCar);
                acessoDadosSqlServer.AdicionarParametros("NumeroParcela", gasto.numeroParcela);
                acessoDadosSqlServer.AdicionarParametros("TipoGasto", gasto.tipoGasto);
                acessoDadosSqlServer.AdicionarParametros("ValorParcela", gasto.valorParcela);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereGasto").ToString();
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
        /// deleta gasto do sistema
        /// </summary>
        /// <param name="gasto"></param>
        /// <returns></returns>

        public string DeletarGasto(GastoDTO gasto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_id", gasto.id);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaGasto").ToString();
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
        /// busta todos os gastos cadastrado
        /// </summary>
        /// <returns></returns>

        public string PesquisaGasto()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarGasto").ToString();
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
        /// busca todos os gasto do carro referente o codigo digitado
        /// </summary>
        /// <param name="gasto"></param>
        /// <returns></returns>

        public string PesquisaIdCarGasto(GastoDTO gasto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID ", gasto.idCar);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisaridCarGasto").ToString();
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
        /// pesquisa o gaasto de acordo seu codigo de identificação
        /// </summary>
        /// <param name="gasto"></param>
        /// <returns></returns>

        public string PesquisaIdGasto(GastoDTO gasto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("ID", gasto.id);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdGasto").ToString();
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
        /// faz alteraçao de dados do gasto
        /// </summary>
        /// <param name="gasto"></param>
        /// <returns></returns>

        public string AlterarGasto(GastoDTO gasto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", gasto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_NumeroParcela", gasto.numeroParcela);
                acessoDadosSqlServer.AdicionarParametros("_TipoGasto", gasto.tipoGasto);
                acessoDadosSqlServer.AdicionarParametros("_ValorParcela", gasto.valorParcela);
                acessoDadosSqlServer.AdicionarParametros("_id", gasto.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarGasto").ToString();
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
    }
}
