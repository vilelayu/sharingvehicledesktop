using System;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.BancoDados;
using System.Data;


namespace sharingvehicledesktop.Negocios
{
 class MotoristaNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// cadastra dados do motorista
        /// </summary>
        /// <param name="motorista"></param>
        /// <returns></returns>
        
        public string InserirMotorista(MotoristaDTO motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Nome", motorista.nome);
                acessoDadosSqlServer.AdicionarParametros("CNH", motorista.cnh);
                acessoDadosSqlServer.AdicionarParametros("CPF", motorista.cpf);
                acessoDadosSqlServer.AdicionarParametros("DataNascimento", motorista.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("DataVencimentoCNH", motorista.dataVencimentoCnh);
                acessoDadosSqlServer.AdicionarParametros("Usuario_idUsuario", motorista.idUsuario);
               
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereMotorista").ToString();
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
        /// excluir os dados do motorista selecionado
        /// </summary>
        /// <param name="motorista"></param>
        /// <returns></returns>
        public string DeletaMotorista(MotoristaDTO motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
             
                acessoDadosSqlServer.AdicionarParametros("_ID", motorista.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaMotorista").ToString();
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
        /// permite alterar dados do motorista
        /// </summary>
        /// <param name="motorista"></param>
        /// <returns></returns>
        public string AlteraMotorista(MotoristaDTO motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_Nome", motorista.nome);
                acessoDadosSqlServer.AdicionarParametros("_CNH", motorista.cnh);
                acessoDadosSqlServer.AdicionarParametros("_CPF", motorista.cpf);
                acessoDadosSqlServer.AdicionarParametros("_DataNascimento", motorista.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("_DataVencimentoCNH", motorista.dataVencimentoCnh);
                acessoDadosSqlServer.AdicionarParametros("_Usuario_idUsuario", motorista.idUsuario);
                acessoDadosSqlServer.AdicionarParametros("_ID", motorista.id);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarMotorista").ToString();
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
        /// permite visualizar todos os motoristas cadastrado
        /// </summary>
        /// <returns></returns>
        public string PesquisaMotorista()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarMotorista").ToString();
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
        /// pesquisa os motorista de acordo do id
        /// </summary>
        /// <param name="motorista"></param>
        /// <returns></returns>
        public string PesquisaMotoristaId(MotoristaDTO motorista)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_ID", motorista.id);
                acessoDadosSqlServer.AdicionarParametros("_Usuario_idUsuario", motorista.idUsuario);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdMotorista").ToString();
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
