using System;
using System.Data;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;


namespace sharingvehicledesktop.Negocios
{
    class DeslocamentoNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// retorna todos os deloscamento feito
        /// </summary>
        /// <returns></returns>

        public string PesquisarDeslocamento()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarDeslocamento").ToString();
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
        /// inseri os deslocamento efetuado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string InserteDeslocamento(DeslocamentoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("Data", dto.data);
                acessoDadosSqlServer.AdicionarParametros("QuilometragemDeslocada", dto.quilometragemDeslocada);
                acessoDadosSqlServer.AdicionarParametros("Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("Motorista_ID", dto.idMotorista);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereDeslocamento").ToString();
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
        /// apaga os dados do deslocamento selecionado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string DeletaDeslocamento(DeslocamentoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
           
                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorista_ID", dto.idMotorista);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaDeslocamento").ToString();
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
        /// retorna o deslocamento de acordo o id informado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string PesquisaIdDeslocamento(DeslocamentoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorista_ID", dto.idMotorista);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdDeslocamento").ToString();
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
        /// faz alteraçao dos dados do deslocamento selecionado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string AlteraDeslocamento(DeslocamentoDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorista_ID", dto.idMotorista);
                acessoDadosSqlServer.AdicionarParametros("_Data", dto.data);
                acessoDadosSqlServer.AdicionarParametros("_QuilometragemDeslocada", dto.quilometragemDeslocada);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarDeslocamento").ToString();
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
