using System;
using System.Data;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.BancoDados;


namespace sharingvehicledesktop.Negocios
{
    class RevisaoNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// insere os dados da revisao
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string InserirRevisao(RevisaoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("DataEntrada", dto.dataEntrada);
                acessoDadosSqlServer.AdicionarParametros("DataSaida", dto.dataSaida);
                acessoDadosSqlServer.AdicionarParametros("HoraEntrada", dto.horaEntrada);
                acessoDadosSqlServer.AdicionarParametros("HoraSaida", dto.horaSaida);
                acessoDadosSqlServer.AdicionarParametros("Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("NomeItem", dto.nomeItem);
                acessoDadosSqlServer.AdicionarParametros("NomeOficina", dto.NomeOficina);
                acessoDadosSqlServer.AdicionarParametros("Preco", dto.preco);
                acessoDadosSqlServer.AdicionarParametros("Quantidade", dto.quantidade);
                acessoDadosSqlServer.AdicionarParametros("Tipo", dto.tipo);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereRevisao").ToString();
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
        /// apagar os dados da revisao
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string DeletaRevisao(RevisaoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);
               

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaRevisao").ToString();
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
        /// faz alteraçao de informaçao das revisao
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string AlteraRevisao(RevisaoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_DataEntrada", dto.dataEntrada);
                acessoDadosSqlServer.AdicionarParametros("_DataSaida", dto.dataSaida);
                acessoDadosSqlServer.AdicionarParametros("_HoraEntrada", dto.horaEntrada);
                acessoDadosSqlServer.AdicionarParametros("_HoraSaida", dto.horaSaida);
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_NomeItem", dto.nomeItem);
                acessoDadosSqlServer.AdicionarParametros("_NomeOficina", dto.NomeOficina);
                acessoDadosSqlServer.AdicionarParametros("_Preco", dto.preco);
                acessoDadosSqlServer.AdicionarParametros("_Quantidade", dto.quantidade);
                acessoDadosSqlServer.AdicionarParametros("_Tipo", dto.tipo);
                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarRevisao").ToString();
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
        /// tras todas as revisao feita
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        
        public string PesquisaRevisao( )
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarRevisao").ToString();
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
        /// traas as revisao cadastrada no id
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string PesquisarIDRevisao(RevisaoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

              
                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarIdRevisao").ToString();
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
