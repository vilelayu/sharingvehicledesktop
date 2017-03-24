using System;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.BancoDados;
using System.Data;
using System.Windows.Forms;

namespace sharingvehicledesktop.Negocios
{
    class UsuarioNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();

        /// <summary>
        /// cadastra novos usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string InserirUsuario(UsuarioDTO usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                
                acessoDadosSqlServer.AdicionarParametros("Nome", usuario.nome);
                acessoDadosSqlServer.AdicionarParametros("Senha", usuario.senha);
             
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereUsuario").ToString();
                return retorno + "Cadastro efetuado com sucesso!";
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
        /// apaga  usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string DeletarUsuario(UsuarioDTO usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_idUsuario", usuario.id);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaUsuario").ToString();
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
        /// altera os dados cadastrado do usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string AtualizarUsuario(UsuarioDTO usuario)
        {
            acessoDadosSqlServer = new AcessoBancoDeDados();

            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_idUsuario", usuario.id);
                acessoDadosSqlServer.AdicionarParametros("_Senha", usuario.senha);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarUsuario").ToString();
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
        /// pesquisa usuario via o id dele no banco
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string PesquisaUsuarioID(UsuarioDTO usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_idUsuario", usuario.id);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdUsuario").ToString();
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
        /// retorna todos os usuarios cadastrados
        /// </summary>
        /// <returns></returns>
        public string PesquisaUsuario()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarUsuario").ToString();
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
        /// permite usuario logar no sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public string PesquisaLogin(UsuarioDTO usuario)
        {
            acessoDadosSqlServer = new AcessoBancoDeDados(); 
            string retorno; 
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_Nome", usuario.nome);
                acessoDadosSqlServer.AdicionarParametros("_Senha", usuario.senha);

                retorno = (acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spLoginEntrarUsuario")).ToString();               
                return retorno;             
            }
            catch (Exception exception)
            {
                retorno = "Não foi possível se conectar ao Banco! Tente novamente mais tarde.." + exception.Message;    
            }
            finally
            {
                acessoDadosSqlServer = null;
            }
            return retorno;
        }
    }
}
