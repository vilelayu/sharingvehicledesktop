using System;
using System.Data;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;

namespace sharingvehicledesktop.Negocios
{
    class GrupoNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
    /// inserir novos grupos 
    /// </summary>
    /// <param name="grupo"></param>
    /// <returns></returns>

        public string InserirGrupo(GrupoDTO grupo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Agenda_id", grupo.idAgenda);
                acessoDadosSqlServer.AdicionarParametros("Rateio_id", grupo.idRateio);
                acessoDadosSqlServer.AdicionarParametros("Nome", grupo.nome);
                acessoDadosSqlServer.AdicionarParametros("Regiao", grupo.regiao);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereGrupo").ToString();
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
        /// apaga o grupo criado
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>

        public string DeletarGrupo(GrupoDTO grupo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

               
                acessoDadosSqlServer.AdicionarParametros("_id", grupo.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaGrupo").ToString();
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
        /// faz atualização dos dados do grupo
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>

        public string AlterarGrupo(GrupoDTO grupo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Agenda_id", grupo.idAgenda);
                acessoDadosSqlServer.AdicionarParametros("_Rateio_id", grupo.idRateio);
                acessoDadosSqlServer.AdicionarParametros("_Nome", grupo.nome);
                acessoDadosSqlServer.AdicionarParametros("_Regiao", grupo.regiao);
                acessoDadosSqlServer.AdicionarParametros("_id", grupo.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarGrupo").ToString();
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
        /// busca todos os grupos cadastrados
        /// </summary>
        /// <returns></returns>

        public string PesquisaGrupo()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarGrupo").ToString();
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
        /// busca o grupo do codigo digitato
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>

        public string PesquisaIdGrupo(GrupoDTO grupo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

        
                acessoDadosSqlServer.AdicionarParametros("_Rateio_id", grupo.idRateio);
                acessoDadosSqlServer.AdicionarParametros("_Agenda_id", grupo.idAgenda);


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdGrupo").ToString();
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
