using System;
using System.Data;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;


namespace sharingvehicledesktop.Negocios
{
    class AgendaNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// busca todos os dados da agenda
        /// </summary>
        /// <returns></returns>

        public string PesquisarAgenda()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarAgenda").ToString();
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
        /// busca os dados referente ao id selecionado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string PesquisaIdAgenda(AgendaDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorisata_ID", dto.idMotorista);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdAgenda").ToString();
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
        /// perrmite cadastrar os dodos da agenda
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string InserirAgenda(AgendaDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("Motorisata_ID", dto.idMotorista);
                acessoDadosSqlServer.AdicionarParametros("Horario", dto.horario);
                acessoDadosSqlServer.AdicionarParametros("Dia", dto.dia);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereAgenda").ToString();
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
        /// apaga os dados selecionado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string delatarAgenda(AgendaDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorisata_ID", dto.idMotorista);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaAgenda").ToString();
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
        /// faz alteração de dados na agenda
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string AlterarAgenda(AgendaDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_Motorisata_ID", dto.idMotorista);
                acessoDadosSqlServer.AdicionarParametros("_Horario", dto.horario);
                acessoDadosSqlServer.AdicionarParametros("_Dia", dto.dia);


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarAgenda").ToString();
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
